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
using Action = CraftMacroMatcher.Structs.Action;

namespace CraftMacroMatcher.ChildForms
{
    public partial class ExportMacro : Form
    {
        List<Action> actions;
        string macro1 = "";
        string macro2 = "";
        string macro3 = "";
        string macro4 = "";
        public ExportMacro(List<Action> actions)
        {
            this.actions = actions;
            InitializeComponent();
        }

        private void BTN_COPY_1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_COPY_2_Click(object sender, EventArgs e)
        {

        }

        private void BTN_COPY_3_Click(object sender, EventArgs e)
        {

        }

        private void BTN_COPY_4_Click(object sender, EventArgs e)
        {

        }

        private void ExportMacro_Load(object sender, EventArgs e)
        {
            CBX_LAN.Text = "中文";
        }
    }
}
