using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CraftMacroMatcher.Structs;
using static CraftMacroMatcher.Actions;
using Newtonsoft.Json;

namespace CraftMacroMatcher.ChildForms
{
    public partial class AddCraftProcess : Form
    {
        Dictionary<string, List<CraftProcess>> Processes;
        string key, value;
        public AddCraftProcess(dynamic data)
        {
            this.Processes = data;
            InitializeComponent();
        }
        private new readonly string Enter = @"
";
        private void AddCraftProcess_Load(object sender, EventArgs e)
        {
            SurfTargets(sender, e);
        }
        private void CBX_LOAD_PROCESS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBX_LOAD_PROCESS.Text == "新增...")
            {
                ClearTexts(sender, e);
                return;
            }
            string[] texts = CBX_LOAD_PROCESS.Text.Split(' ');
            key = texts[0]; value = texts[2];
            var loadProcess = Processes[key].Find(x => x.name == value);
            TBX_PROCESS_NAME.Text = loadProcess.name;
            CBX_CRAFT_TARGET.Text = loadProcess.targetItemName;
            NUD_CRAFTSMANSHIP.Value = loadProcess.need_craftsmanship;
            NUD_CONTROL.Value = loadProcess.need_control;
            TBX_PROCESS.Text = "";
            foreach (var a in loadProcess.actions)
            {
                TBX_PROCESS.Text += $"/ac \"{a.name_cn}\" <wait.{a.wait_time}>{Enter}";
            }
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            if (CBX_CRAFT_TARGET.Text == "")
            {
                MessageBox.Show("请选择制作目标");
                return;
            }
            if(TBX_PROCESS.Text == "")
            {
                MessageBox.Show("请输入工序");
                return;
            }
            if (CBX_LOAD_PROCESS.Text != "新增..." && CBX_LOAD_PROCESS.Text != "")
            {
                var loadProcess = Processes[key].Find(x => x.name == value);
                Processes[key].Remove(loadProcess);
            }
            CraftProcess cp = new CraftProcess();
            cp.name = TBX_PROCESS_NAME.Text == "" ? $"未命名工序_{DateTime.Now:yyyy-MM-dd_hh:mm:ss:fff}" :TBX_PROCESS_NAME.Text.Replace(' ', '_');
            if (key != null && Processes[key].Find(x => x.name == cp.name).name != null)
            {
                MessageBox.Show("此制作对象下已存在同名工序");
                return;
            }
            cp.targetItemName = CBX_CRAFT_TARGET.Text;
            cp.need_craftsmanship = (int)NUD_CRAFTSMANSHIP.Value;
            cp.need_control = (int)NUD_CONTROL.Value;

            string processText = TBX_PROCESS.Text;
            List<string> processes = new List<string>();
            try
            {
                if (RBT_MACRO.Checked)
                {
                    string[] processLines = processText.Split('\n');
                    foreach (string processLine in processLines)
                    {
                        if (processLine==""|| processLine==" ") { continue; }
                        string[] strs = processLine.Split(' ');
                        if (strs[0]!="/ac" && strs[0]!="/action" && strs[0]!="/技能") 
                        { 
                            continue; 
                        }
                        var actName = strs[1];
                        if (actName[0] == '"') { actName = actName.Substring(1, actName.Length - 2); }
                        processes.Add(actName);
                    }
                }
                if (RBT_SIMULATOR_PROCESS.Checked)
                {
                    processes = JsonConvert.DeserializeObject<List<string>>(processText);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"输入的工序格式错误。错误详情：\n{ex}");
                return;
            }

            List<Structs.Action> actProcess = new List<Structs.Action>();
            foreach (var process in processes)
            {
                var p = Actions.SearchAction(process);
                actProcess.Add(p);
            }
            if (actProcess.Count <= 0)
            {
                MessageBox.Show("未在输入内容中检测到工序");
                return;
            }
            cp.steps = 0;
            cp.times = 0;
            cp.need_cp = 0;
            for(int i = 0; i < actProcess.Count; i++)
            {
                var act = actProcess[i];
                cp.steps ++;
                cp.times += act.wait_time;
                if(act.id==(int)ActId.StandardTouch || act.id == (int)ActId.AdvancedTouch)
                {
                    try
                    {
                        if (act.id == (int)ActId.StandardTouch)
                        {
                            cp.need_cp += actProcess[i-1].id == (int)ActId.BasicTouch ? 18 : act.cp_cost;
                            continue;
                        }
                        if (act.id == (int)ActId.AdvancedTouch)
                        {
                            if(actProcess[i-2].id == (int)ActId.BasicTouch && actProcess[i-1].id == (int)ActId.StandardTouch)
                            {
                                cp.need_cp += 18; continue;
                            }
                        }
                    }
                    catch { }
                }
                cp.need_cp += act.cp_cost;
            }
            cp.actions = actProcess;
            
            if (Processes.ContainsKey(cp.targetItemName))
            {
                Processes[cp.targetItemName].Add(cp);
            }
            else
            {
                Processes.Add(cp.targetItemName, new List<CraftProcess>() { cp });
            }

            string json = JsonConvert.SerializeObject(Processes);
            System.IO.File.WriteAllText(ProgramDatas.ProcessPath, json);

            MessageBox.Show("工序添加/编辑成功");
            Processes = MainForm.LoadProcesses();

            ClearTexts(sender, e);
            SurfTargets(sender, e);
        }

        private void ClearTexts(object sender, EventArgs e)
        {
            TBX_PROCESS_NAME.Text = "";
            CBX_CRAFT_TARGET.Text = "";
            TBX_PROCESS.Text = "";
        }

        private void BTN_EDIT_TARGETS_Click(object sender, EventArgs e)
        {
            string targets = "";
            foreach(var d in Processes)
            {
                targets += d.Key + "\n";
            }
            ManageTargets mt = new ManageTargets(targets);
            mt.ShowDialog();
            Processes = MainForm.LoadProcesses();
            SurfTargets(sender, e);
        }

        private void BTN_MACRO_EDITOR_Click(object sender, EventArgs e)
        {
            MacroEditor me = new MacroEditor(this);
            me.ShowDialog();
        }
        public void ChangeMacroText(string text, object sender, EventArgs e)
        {
            TBX_PROCESS.Text = text;
        }

        private void BTN_DEL_PROCESS_Click(object sender, EventArgs e)
        {
            if (CBX_LOAD_PROCESS.Text == "新增..." || CBX_LOAD_PROCESS.Text == "")
            {
                MessageBox.Show("尚未选择工序");
                return;
            }
            try
            {
                string[] texts = CBX_LOAD_PROCESS.Text.Split(' ');
                key = texts[0]; value = texts[2];
                var loadProcess = Processes[key].Find(x => x.name == value);
                Processes[key].Remove(loadProcess);
                string json = JsonConvert.SerializeObject(Processes);
                System.IO.File.WriteAllText(ProgramDatas.ProcessPath, json);
                MessageBox.Show("工序删除成功");
                Processes = MainForm.LoadProcesses();
                SurfTargets(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"此工序不存在或删除失败\nDetail:{ex}");
                return;
            }
        }

        private void SurfTargets(object sender, EventArgs e)
        {
            CBX_CRAFT_TARGET.Items.Clear();
            foreach (var p in Processes)
            {
                CBX_CRAFT_TARGET.Items.Add(p.Key);
            }
            CBX_LOAD_PROCESS.Items.Clear();
            CBX_LOAD_PROCESS.Items.Add("新增...");
            foreach (var p in Processes)
            {
                foreach (var cp in p.Value)
                {
                    CBX_LOAD_PROCESS.Items.Add($"{p.Key} - {cp.name}");
                }
            }
        }

    }
}
