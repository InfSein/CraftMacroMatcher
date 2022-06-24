using Newtonsoft.Json;
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

namespace CraftMacroMatcher.ChildForms
{
    public partial class ManageTargets : Form
    {
        string targets;
        public ManageTargets(string targets)
        {
            this.targets = targets;
            InitializeComponent();
        }

        private void ManageTargets_Load(object sender, EventArgs e)
        {
            TBX_TARGETS.Text = targets;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult MsgBoxResult;
            MsgBoxResult = MessageBox.Show("重命名或删除制作目标会删除与它关联的所有工序。\n要继续吗?", "警告",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button2);
            if (MsgBoxResult == DialogResult.No) { return; }
            Dictionary<string, List<CraftProcess>> dict = MainForm.LoadProcesses();
            Dictionary<string, List<CraftProcess>> newdict = new Dictionary<string, List<CraftProcess>>();
            string[] targets = TBX_TARGETS.Text.Split('\n');
            foreach (string target in targets)
            {
                var t = target.Replace(' ', '_');
                if (target == "" || target == " ") continue;
                if (dict.ContainsKey(t))
                {
                    newdict.Add(t, dict[t]);
                }
                else
                {
                    newdict.Add(t, new List<CraftProcess>());
                }
            }
            string str = JsonConvert.SerializeObject(newdict);
            System.IO.File.WriteAllText(ProgramDatas.ProcessPath, str);
            MessageBox.Show("保存成功");
            this.Close();
        }
    }
}
