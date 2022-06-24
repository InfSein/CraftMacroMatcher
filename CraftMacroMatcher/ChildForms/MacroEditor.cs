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
    public partial class MacroEditor : Form
    {
        AddCraftProcess parent;
        List<Action> selectedActions;
        List<Button> CurrActBtns;
        Point actStartPos;
        int xAdd, yAdd;
        public MacroEditor()
        {
            InitializeComponent();
        }
        public MacroEditor(AddCraftProcess parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        new readonly string Enter = @"
";

        private void MacroEditor_Load(object sender, EventArgs e)
        {
            selectedActions = new List<Action>();
            CurrActBtns = new List<Button>();
            GetLocations(sender, e);
            foreach(Control c in this.Controls)
            {
                if (c is Button)
                {
                    toolTip1.SetToolTip(c, c.Name);
                }
            }
        }

        private void OnActionButtonClicked(object sender, EventArgs e)
        {
            string buttonName = ((Button)sender).Name;
            Action action = Actions.SearchAction(buttonName);
            selectedActions.Add(action);
            ShowActions();
        }
        private void DeleteAct(object sender, EventArgs e)
        {
            string actCount = ((Button)sender).Name.Split('_')[1];
            selectedActions.RemoveAt(int.Parse(actCount)-1);
            ShowActions();
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowActions()
        {
            int count = 1;
            Point next = actStartPos;
            foreach(var b in CurrActBtns)
            {
                this.Controls.Remove(b);
                b.Dispose();
            }
            foreach (Action action in selectedActions)
            {
                Button button = GetButton(action);
                button.Name = $"act_{count}";
                button.Click += DeleteAct;
                button.Location = next;
                button.Visible = true;
                button.Enabled = true;
                if (count % 5 == 0)
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
        public Button GetButton(Action action)
        {
            Button btn = new Button();
            Button fatherBtn = (Button)Controls.Find(action.name_cn, true)[0];
            btn.Text = fatherBtn.Text;
            btn.BackgroundImage = fatherBtn.BackgroundImage;
            btn.BackgroundImageLayout = fatherBtn.BackgroundImageLayout;
            btn.Size = fatherBtn.Size;
            btn.Visible = true;
            btn.Enabled = true;
            return btn;
        }

        private void BTN_CLEAR_PROCESSES_Click(object sender, EventArgs e)
        {
            selectedActions.Clear();
            ShowActions();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            string macroText = "";
            foreach (Action a in selectedActions)
            {
                macroText += $"/ac \"{a.name_cn}\" <wait.{a.wait_time}>" + Enter;
            }
            parent.ChangeMacroText(macroText, sender, e);
            this.Close();
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
    }
}
