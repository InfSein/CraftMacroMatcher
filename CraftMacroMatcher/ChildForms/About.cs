using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CraftMacroMatcher.ChildForms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.label1.Text = $"能工巧匠配宏器 {ProgramDatas.MacroMatcherPatch}\r\n作者: InfSein\r\n(预装)工序作者: 啵带, 月下";
        }
    }
}
