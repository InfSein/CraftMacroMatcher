﻿using System;
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
    public partial class MacroEditor : Form
    {
        AddCraftProcess parent;
        public MacroEditor(AddCraftProcess parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void MacroEditor_Load(object sender, EventArgs e)
        {
            parent.ChangeMacroText("", sender, e);
        }
    }
}
