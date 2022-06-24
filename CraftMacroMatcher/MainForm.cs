using CraftMacroMatcher.ChildForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static CraftMacroMatcher.Structs;

namespace CraftMacroMatcher
{
    public partial class MainForm : Form
    {
        INIUtil ini;
        Dictionary<string, List<CraftProcess>> Processes;
        Dictionary<string, FoodProps> Foods;
        Dictionary<string, FoodProps> Tincs;
        List<string> CraftTargets;
        List<Button> CurrActBtns;
        List<CraftProcess> CurrProcesses;
        FoodProps CurrFood;
        FoodProps CurrTinc;

        int trueCraftsmanship, trueControl, trueCp;
        Point actStartPos;
        int xAdd, yAdd;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetLocations(sender, e);
            Processes = LoadProcesses();
            CraftTargets = LoadTargets();
            ShowTargets(sender, e);
            Foods = LoadFoods();
            ShowFoods(sender, e);
            Tincs = LoadTincs();
            ShowTincs(sender, e);
            CurrFood = InitFood();
            CurrTinc = InitFood();
            CurrProcesses = new List<CraftProcess>();
            CurrActBtns = new List<Button>();
            ini = new INIUtil();
            NUD_Craftsmanship.Value = ini.ReadValueInt(INIUtil.Craftsmanship);
            NUD_Control.Value = ini.ReadValueInt(INIUtil.Control);
            NUD_CP.Value = ini.ReadValueInt(INIUtil.Cp);
            CBX_IS_MASTER.Checked = ini.ReadValueBool(INIUtil.IsMaster);
        }
        private FoodProps InitFood()
        {
            return new FoodProps
            {
                craftsmanshipAdd_Percent = 0,
                craftsmanshipAdd_Max = 0,
                controlAdd_Percent = 0,
                controlAdd_Max = 0,
                cpAdd_Percent = 0,
                cpAdd_Max = 0,
                name = ""
            };
        }
        private void CBX_PROCESS_SELECTED_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBX_PROCESS_SELECTED.Text == "没有可用的工序")
            {
                return;
            }
            try
            {
                string processName = CBX_PROCESS_SELECTED.Text.Split(' ')[1];
                CraftProcess selectedProcess = CurrProcesses.Find(l => l.name == processName);
                LAB_NEED.Text = $"需要: {selectedProcess.need_craftsmanship}/{selectedProcess.need_control}/{selectedProcess.need_cp}";
                MacroEditor me = new MacroEditor();
                int count = 1;
                Point next = actStartPos;
                foreach (var b in CurrActBtns)
                {
                    this.Controls.Remove(b);
                    b.Dispose();
                }
                foreach (var a in selectedProcess.actions)
                {
                    Button button = me.GetButton(a);
                    button.Name = $"act_{count}";
                    button.Location = next;
                    button.Visible = true;
                    button.Enabled = true;
                    if (count % 7 == 0)
                    {
                        next.X = actStartPos.X;
                        next.Y += yAdd;
                    }
                    else
                    {
                        next.X += xAdd;
                    }
                    count++;
                    CurrActBtns.Add(button);
                    panel1.Controls.Add(button);
                }
                
            }
            catch { }
        }
        private void GetLocations(object sender, EventArgs e)
        {
            actStartPos = BTN_1_1.Location;
            xAdd = BTN_1_2.Location.X - actStartPos.X;
            yAdd = BTN_2_1.Location.Y - actStartPos.Y;
            BTN_1_1.Visible = false;
            BTN_1_2.Visible = false;
            BTN_2_1.Visible = false;
        }

        private void CBX_CRAFT_TARGET_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Processes.ContainsKey(CBX_CRAFT_TARGET.Text))
            {
                CurrProcesses = Processes[CBX_CRAFT_TARGET.Text];
            }
            int getNum = 0, totalNum = 0;
            CBX_PROCESS_SELECTED.Items.Clear();
            foreach (var l in CurrProcesses)
            {
                totalNum++;
                if (l.need_craftsmanship <= trueCraftsmanship)
                    if(l.need_control <= trueControl && l.need_cp <= trueCp)
                    {
                        getNum++;
                        CBX_PROCESS_SELECTED.Items.Add($"[{l.steps}步{l.times}秒] {l.name}");
                    }
            }
            if (CBX_PROCESS_SELECTED.Items.Count == 0)
            {
                CBX_PROCESS_SELECTED.Items.Add("没有可用的工序");
            }
            SLAB_TIP.Text = $"找到了{totalNum}个工序，其中有{getNum}个达到了最低要求";
        }

        private void ShowTargets(object sender, EventArgs e)
        {
            CBX_CRAFT_TARGET.Items.Clear();
            foreach (var l in CraftTargets)
            {
                CBX_CRAFT_TARGET.Items.Add(l);
            }
        }

        public List<string> LoadTargets()
        {
            List<string> targets = new List<string>();
            foreach(var p in Processes)
            {
                targets.Add(p.Key);
            }
            return targets;
        }
        
        public static dynamic LoadProcesses()
        {
            if (!File.Exists(ProgramDatas.ProcessPath))
                return new Dictionary<string, List<CraftProcess>>();
            try
            {
                string content = File.ReadAllText(ProgramDatas.ProcessPath);
                var data = JsonConvert.DeserializeObject<Dictionary<string, List<CraftProcess>>>(content);
                return data;
            }
            catch
            {
                return new Dictionary<string, List<CraftProcess>>();
            }
        }

        private void ShowFoods(object sender, EventArgs e)
        {
            CBX_FOODS.Items.Clear();
            foreach(var f in Foods)
            {
                CBX_FOODS.Items.Add(f.Key);
            }
        }
        public static dynamic LoadFoods()
        {
            if (!File.Exists(ProgramDatas.FoodPath))
                return new Dictionary<string, FoodProps>();
            try
            {
                string content = File.ReadAllText(ProgramDatas.FoodPath);
                var data = JsonConvert.DeserializeObject<Dictionary<string, FoodProps>>(content);
                return data;
            }
            catch
            {
                return new Dictionary<string, FoodProps>();
            }
        }
        private void ShowTincs(object sender, EventArgs e)
        {
            CBX_TINCS.Items.Clear();
            foreach (var f in Tincs)
            {
                CBX_TINCS.Items.Add(f.Key);
            }
        }
        public static dynamic LoadTincs()
        {
            if (!File.Exists(ProgramDatas.TincPath))
                return new Dictionary<string, FoodProps>();
            try
            {
                string content = File.ReadAllText(ProgramDatas.TincPath);
                var data = JsonConvert.DeserializeObject<Dictionary<string, FoodProps>>(content);
                return data;
            }
            catch
            {
                return new Dictionary<string, FoodProps>();
            }
        }

        #region 存储个人属性,刷新
        private void NUD_Craftsmanship_ValueChanged(object sender, EventArgs e)
        {
            ini.Write(INIUtil.Craftsmanship, NUD_Craftsmanship.Value);
            SurfProps(sender, e);
        }
        private void NUD_Control_ValueChanged(object sender, EventArgs e)
        {
            ini.Write(INIUtil.Control, NUD_Control.Value);
            SurfProps(sender, e);
        }
        private void NUD_CP_ValueChanged(object sender, EventArgs e)
        {
            ini.Write(INIUtil.Cp, NUD_CP.Value);
            SurfProps(sender, e);
        }
        private void CBX_IS_MASTER_CheckedChanged(object sender, EventArgs e)
        {
            ini.Write(INIUtil.IsMaster, CBX_IS_MASTER.Checked);
            SurfProps(sender, e);
        }

        private void SurfProps(object sender, EventArgs e)
        {
            int craftAdd1 = (int)(CurrFood.craftsmanshipAdd_Percent / 100 * (int)NUD_Craftsmanship.Value) > CurrFood.craftsmanshipAdd_Max ? CurrFood.craftsmanshipAdd_Max : (int)(CurrFood.craftsmanshipAdd_Percent / 100 * (int)NUD_Craftsmanship.Value);
            int controlAdd1 = (int)(CurrFood.controlAdd_Percent / 100 * (int)NUD_Control.Value) > CurrFood.controlAdd_Max ? CurrFood.controlAdd_Max : (int)(CurrFood.controlAdd_Percent / 100 * (int)NUD_Control.Value);
            int cpAdd1 = (int)(CurrFood.cpAdd_Percent / 100 * (int)NUD_CP.Value) > CurrFood.cpAdd_Max ? CurrFood.cpAdd_Max : (int)(CurrFood.cpAdd_Percent / 100 * (int)NUD_CP.Value);
            int craftAdd2 = (int)(CurrTinc.craftsmanshipAdd_Percent / 100 * (int)NUD_Craftsmanship.Value) > CurrTinc.craftsmanshipAdd_Max ? CurrTinc.craftsmanshipAdd_Max : (int)(CurrTinc.craftsmanshipAdd_Percent / 100 * (int)NUD_Craftsmanship.Value);
            int controlAdd2 = (int)(CurrTinc.controlAdd_Percent / 100 * (int)NUD_Control.Value) > CurrTinc.controlAdd_Max ? CurrTinc.controlAdd_Max : (int)(CurrTinc.controlAdd_Percent / 100 * (int)NUD_Control.Value);
            int cpAdd2 = (int)(CurrTinc.cpAdd_Percent / 100 * (int)NUD_CP.Value) > CurrTinc.cpAdd_Max ? CurrTinc.cpAdd_Max : (int)(CurrTinc.cpAdd_Percent / 100 * (int)NUD_CP.Value);
            int craftAdd = craftAdd1 + craftAdd2;
            int controlAdd = controlAdd1 + controlAdd2;
            int cpAdd = cpAdd1 + cpAdd2;

            trueCraftsmanship = (int)NUD_Craftsmanship.Value + craftAdd;
            trueControl = (int)NUD_Control.Value + controlAdd;
            trueCp = (int)NUD_CP.Value + cpAdd;

            SLAB_TIP.Text = $"更新成功。当前实际属性：作业{trueCraftsmanship},加工{trueControl},CP{trueCp}";
        }
        #endregion

        private void 添加工序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCraftProcess acp = new AddCraftProcess(Processes);
            acp.ShowDialog();
            SurfProcessSets(sender, e);
        }

        private void SurfProcessSets(object sender, EventArgs e)
        {
            Processes = LoadProcesses();
            CraftTargets = LoadTargets();
            ShowTargets(sender, e);
        }
        private string GetProcessSets()
        {
            // to-do: from local, or from resource.
            return "";
        }

        private void 添加编辑药水ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTinc at = new AddTinc();
            at.ShowDialog();
            Tincs = LoadTincs();
            ShowTincs(sender, e);
        }

        private void BTN_EXPORT_MACRO_Click(object sender, EventArgs e)
        {

        }

        private void 添加食物ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFood af = new AddFood();
            af.ShowDialog();
            Foods = LoadFoods();
            ShowFoods(sender, e);
        }

        private void CBX_FOODS_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrFood = Foods[CBX_FOODS.Text];
            SurfProps(sender, e);
        }
        private void CBX_TINCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrTinc = Tincs[CBX_TINCS.Text];
            SurfProps(sender, e);
        }
    }
}
