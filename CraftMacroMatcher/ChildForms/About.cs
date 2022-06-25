using Microsoft.Win32;
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

        private void button1_Click(object sender, EventArgs e)
        {
            OuterWebsiteVisitConfirm(ProgramDatas.ProjectPath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OuterWebsiteVisitConfirm(ProgramDatas.DonatePath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OuterWebsiteVisitConfirm(string url)
        {
            if (url == "")
            {
                MessageBox.Show("敬请期待");
                return;
            }
            
            DialogResult MsgBoxResult;
            MsgBoxResult = MessageBox.Show("即将打开外部网站。确认要继续吗?", "提示",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button2);
            if (MsgBoxResult == DialogResult.Yes)
            {
                OuterVisit(url);
            }
        }
        private static void OuterVisit(string url)
        {
            try
            {
                RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"http\shell\open\command\");
                if (key == null) throw new Exception();
                String s = key.GetValue("").ToString();
                String browserpath = null;
                if (s.StartsWith("\""))
                {
                    browserpath = s.Substring(1, s.IndexOf('\"', 1) - 1);
                }
                else
                {
                    browserpath = s.Substring(0, s.IndexOf(" "));
                }
                System.Diagnostics.Process.Start(browserpath, url);
            }
            catch
            {
                MessageBox.Show("调用浏览器失败。链接已经被复制到您的剪贴板，请手动操作。");
                Clipboard.SetText(url);
            }
        }
    }
}
