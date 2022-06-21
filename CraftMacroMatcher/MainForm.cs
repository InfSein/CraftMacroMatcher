using CraftMacroMatcher.ChildForms;
using System;
using System.Windows.Forms;

namespace CraftMacroMatcher
{
    public partial class MainForm : Form
    {
        INIUtil ini;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ini = new INIUtil();
            NUD_Craftsmanship.Value = ini.ReadValueInt(INIUtil.Craftsmanship);
            NUD_Control.Value = ini.ReadValueInt(INIUtil.Control);
            NUD_CP.Value = ini.ReadValueInt(INIUtil.Cp);
            CBX_IS_MASTER.Checked = ini.ReadValueBool(INIUtil.IsMaster);
        }

        private void CBX_CRAFT_TARGET_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            AddCraftProcess acp = new AddCraftProcess();
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
