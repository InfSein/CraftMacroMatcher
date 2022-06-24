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
            if (actions == null)
            {
                this.Close();
                return;
            }
            this.actions = actions;
            InitializeComponent();
        }

        private void ExportMacro_Load(object sender, EventArgs e)
        {
            BTN_COPY_2.Enabled = false;
            BTN_COPY_3.Enabled = false;
            BTN_COPY_4.Enabled = false;
            CBX_LAN.Text = "中文";
            if (actions.Count == 0) { this.Close(); }
            if (actions.Count > 57)
            {
                MessageBox.Show($"工序过多({actions.Count}, > 57)!");
                this.Close();
            }

            if (actions.Count > 15) { BTN_COPY_2.Enabled = true; }
            if (actions.Count > 29) { BTN_COPY_3.Enabled = true; }
            if (actions.Count > 43) { BTN_COPY_4.Enabled = true; }

            CalculateMacro(sender, e);
        }

        private void CalculateMacro(object sender, EventArgs e)
        {
            int leftCount = actions.Count;
            int macro1Count = leftCount == 15 ? 15 : leftCount > 15 ? 14 : leftCount;
            macro1 = "";
            for (int i = 0; i < macro1Count; i++)
            {
                macro1 += actions[i].OutPutMacroLine(CBX_LAN.Text);
            }
            macro1 += leftCount == 15 ? "" : "/e 宏#1 已完成<se.1>";
            leftCount -= macro1Count;
            if (leftCount <= 0) return;

            int macro2Count = leftCount == 15 ? 15 : leftCount > 15 ? 14 : leftCount;
            macro2 = "";
            for (int i = 0; i < macro2Count; i++)
            {
                macro2 += actions[i + macro1Count].OutPutMacroLine(CBX_LAN.Text);
            }
            macro2 += leftCount == 15 ? "" : "/e 宏#2 已完成<se.2>";
            leftCount -= macro2Count;
            if (leftCount <= 0) return;

            int macro3Count = leftCount == 15 ? 15 : leftCount > 15 ? 14 : leftCount;
            macro3 = "";
            for (int i = 0; i < macro3Count; i++)
            {
                macro3 += actions[i + macro1Count + macro2Count].OutPutMacroLine(CBX_LAN.Text);
            }
            macro3 += leftCount == 15 ? "" : "/e 宏#3 已完成<se.3>";
            leftCount -= macro3Count;
            if (leftCount <= 0) return;

            int macro4Count = leftCount == 15 ? 15 : leftCount > 15 ? 14 : leftCount;
            macro4 = "";
            for (int i = 0; i < macro4Count; i++)
            {
                macro4 += actions[i + macro1Count + macro2Count + macro3Count].OutPutMacroLine(CBX_LAN.Text);
            }
            macro4 += leftCount == 15 ? "" : "/e 宏#4 已完成<se.4>";
        }

        private void CBX_LAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateMacro(sender, e);
        }
        
        private void BTN_COPY_1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(macro1);
            MessageBox.Show("复制 宏#1 成功");
        }

        private void BTN_COPY_2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(macro2);
            MessageBox.Show("复制 宏#2 成功");
        }

        private void BTN_COPY_3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(macro3);
            MessageBox.Show("复制 宏#3 成功");
        }

        private void BTN_COPY_4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(macro4);
            MessageBox.Show("复制 宏#4 成功");
        }

    }
}
