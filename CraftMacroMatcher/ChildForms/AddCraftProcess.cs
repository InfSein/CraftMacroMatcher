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
        public AddCraftProcess(dynamic data)
        {
            this.Processes = data;
            InitializeComponent();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            if(CBX_CRAFT_TARGET.Text == "")
            {
                MessageBox.Show("请选择制作目标");
                return;
            }
            if(TBX_PROCESS.Text == "")
            {
                MessageBox.Show("请输入工序");
                return;
            }
            CraftProcess cp = new CraftProcess();
            cp.name = TBX_PROCESS_NAME.Text == "" ?"未命名工序" :TBX_PROCESS_NAME.Text;
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
                        if (processLine==""|| processLine==" ") continue;
                        string[] strs = processLine.Split(' ');
                        var actName = strs[1];
                        if (actName[0] == '"') { actName = actName.Substring(1, actName.Length - 1); }
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

            this.Close();
        }

        private void BTN_EDIT_TARGETS_Click(object sender, EventArgs e)
        {
            string targets = "";
            foreach(var d in Processes)
            {
                targets += d.Key + "\n";
            }
        }
    }
}
