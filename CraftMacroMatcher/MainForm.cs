using CraftMacroMatcher.ChildForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static CraftMacroMatcher.Structs;

namespace CraftMacroMatcher
{
    public partial class MainForm : Form
    {
        INIUtil ini;
        Dictionary<string, List<CraftProcess>> Processes;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Processes = LoadProcesses();
            ini = new INIUtil();
            NUD_Craftsmanship.Value = ini.ReadValueInt(INIUtil.Craftsmanship);
            NUD_Control.Value = ini.ReadValueInt(INIUtil.Control);
            NUD_CP.Value = ini.ReadValueInt(INIUtil.Cp);
            CBX_IS_MASTER.Checked = ini.ReadValueBool(INIUtil.IsMaster);
        }

        private void CBX_CRAFT_TARGET_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        #region 存储个人属性
        private void NUD_Craftsmanship_ValueChanged(object sender, EventArgs e)
        {
            ini.Write(INIUtil.Craftsmanship, NUD_Craftsmanship.Value);
        }
        private void NUD_Control_ValueChanged(object sender, EventArgs e)
        {
            ini.Write(INIUtil.Control, NUD_Control.Value);
        }
        private void NUD_CP_ValueChanged(object sender, EventArgs e)
        {
            ini.Write(INIUtil.Cp, NUD_CP.Value);
        }
        private void CBX_IS_MASTER_CheckedChanged(object sender, EventArgs e)
        {
            ini.Write(INIUtil.IsMaster, CBX_IS_MASTER.Checked);
        }
        #endregion

        private void 添加工序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCraftProcess acp = new AddCraftProcess(Processes);
            acp.ShowDialog();
            SurfProcessSets();
        }

        private void SurfProcessSets()
        {
            
        }
        private string GetProcessSets()
        {
            // to-do: from local, or from resource.
            return "";
        }
    }
}
