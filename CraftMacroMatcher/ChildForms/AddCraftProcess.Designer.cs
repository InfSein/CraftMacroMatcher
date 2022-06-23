namespace CraftMacroMatcher.ChildForms
{
    partial class AddCraftProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_EDIT_TARGETS = new System.Windows.Forms.Button();
            this.CBX_CRAFT_TARGET = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NUD_CONTROL = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NUD_CRAFTSMANSHIP = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TBX_PROCESS = new System.Windows.Forms.TextBox();
            this.RBT_SIMULATOR_PROCESS = new System.Windows.Forms.RadioButton();
            this.RBT_MACRO = new System.Windows.Forms.RadioButton();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TBX_PROCESS_NAME = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CBX_LOAD_PROCESS = new System.Windows.Forms.ComboBox();
            this.BTN_MACRO_EDITOR = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CONTROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CRAFTSMANSHIP)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_EDIT_TARGETS);
            this.groupBox1.Controls.Add(this.CBX_CRAFT_TARGET);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(11, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "制作目标";
            // 
            // BTN_EDIT_TARGETS
            // 
            this.BTN_EDIT_TARGETS.Location = new System.Drawing.Point(274, 25);
            this.BTN_EDIT_TARGETS.Name = "BTN_EDIT_TARGETS";
            this.BTN_EDIT_TARGETS.Size = new System.Drawing.Size(75, 29);
            this.BTN_EDIT_TARGETS.TabIndex = 1;
            this.BTN_EDIT_TARGETS.Text = "编辑";
            this.BTN_EDIT_TARGETS.UseVisualStyleBackColor = true;
            this.BTN_EDIT_TARGETS.Click += new System.EventHandler(this.BTN_EDIT_TARGETS_Click);
            // 
            // CBX_CRAFT_TARGET
            // 
            this.CBX_CRAFT_TARGET.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_CRAFT_TARGET.FormattingEnabled = true;
            this.CBX_CRAFT_TARGET.Location = new System.Drawing.Point(25, 26);
            this.CBX_CRAFT_TARGET.Name = "CBX_CRAFT_TARGET";
            this.CBX_CRAFT_TARGET.Size = new System.Drawing.Size(243, 28);
            this.CBX_CRAFT_TARGET.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NUD_CONTROL);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.NUD_CRAFTSMANSHIP);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(11, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "制作要求";
            // 
            // NUD_CONTROL
            // 
            this.NUD_CONTROL.Location = new System.Drawing.Point(272, 21);
            this.NUD_CONTROL.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUD_CONTROL.Name = "NUD_CONTROL";
            this.NUD_CONTROL.Size = new System.Drawing.Size(77, 27);
            this.NUD_CONTROL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "加工精度";
            // 
            // NUD_CRAFTSMANSHIP
            // 
            this.NUD_CRAFTSMANSHIP.Location = new System.Drawing.Point(96, 21);
            this.NUD_CRAFTSMANSHIP.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUD_CRAFTSMANSHIP.Name = "NUD_CRAFTSMANSHIP";
            this.NUD_CRAFTSMANSHIP.Size = new System.Drawing.Size(77, 27);
            this.NUD_CRAFTSMANSHIP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "作业精度";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTN_MACRO_EDITOR);
            this.groupBox3.Controls.Add(this.TBX_PROCESS);
            this.groupBox3.Controls.Add(this.RBT_SIMULATOR_PROCESS);
            this.groupBox3.Controls.Add(this.RBT_MACRO);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(11, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 214);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "导入工序";
            // 
            // TBX_PROCESS
            // 
            this.TBX_PROCESS.Location = new System.Drawing.Point(25, 52);
            this.TBX_PROCESS.Multiline = true;
            this.TBX_PROCESS.Name = "TBX_PROCESS";
            this.TBX_PROCESS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBX_PROCESS.Size = new System.Drawing.Size(324, 145);
            this.TBX_PROCESS.TabIndex = 2;
            // 
            // RBT_SIMULATOR_PROCESS
            // 
            this.RBT_SIMULATOR_PROCESS.AutoSize = true;
            this.RBT_SIMULATOR_PROCESS.Enabled = false;
            this.RBT_SIMULATOR_PROCESS.Location = new System.Drawing.Point(76, 26);
            this.RBT_SIMULATOR_PROCESS.Name = "RBT_SIMULATOR_PROCESS";
            this.RBT_SIMULATOR_PROCESS.Size = new System.Drawing.Size(105, 24);
            this.RBT_SIMULATOR_PROCESS.TabIndex = 1;
            this.RBT_SIMULATOR_PROCESS.Text = "模拟器工序";
            this.RBT_SIMULATOR_PROCESS.UseVisualStyleBackColor = true;
            // 
            // RBT_MACRO
            // 
            this.RBT_MACRO.AutoSize = true;
            this.RBT_MACRO.Checked = true;
            this.RBT_MACRO.Location = new System.Drawing.Point(25, 26);
            this.RBT_MACRO.Name = "RBT_MACRO";
            this.RBT_MACRO.Size = new System.Drawing.Size(45, 24);
            this.RBT_MACRO.TabIndex = 0;
            this.RBT_MACRO.TabStop = true;
            this.RBT_MACRO.Text = "宏";
            this.RBT_MACRO.UseVisualStyleBackColor = true;
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN_SAVE.Location = new System.Drawing.Point(283, 513);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(102, 40);
            this.BTN_SAVE.TabIndex = 3;
            this.BTN_SAVE.Text = "保存";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TBX_PROCESS_NAME);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(11, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(376, 65);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "工序名称";
            // 
            // TBX_PROCESS_NAME
            // 
            this.TBX_PROCESS_NAME.Location = new System.Drawing.Point(25, 26);
            this.TBX_PROCESS_NAME.Name = "TBX_PROCESS_NAME";
            this.TBX_PROCESS_NAME.Size = new System.Drawing.Size(324, 27);
            this.TBX_PROCESS_NAME.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CBX_LOAD_PROCESS);
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(11, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(376, 68);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "读取已有工序";
            // 
            // CBX_LOAD_PROCESS
            // 
            this.CBX_LOAD_PROCESS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_LOAD_PROCESS.FormattingEnabled = true;
            this.CBX_LOAD_PROCESS.Location = new System.Drawing.Point(25, 26);
            this.CBX_LOAD_PROCESS.Name = "CBX_LOAD_PROCESS";
            this.CBX_LOAD_PROCESS.Size = new System.Drawing.Size(324, 28);
            this.CBX_LOAD_PROCESS.TabIndex = 0;
            this.CBX_LOAD_PROCESS.SelectedIndexChanged += new System.EventHandler(this.CBX_LOAD_PROCESS_SelectedIndexChanged);
            // 
            // BTN_MACRO_EDITOR
            // 
            this.BTN_MACRO_EDITOR.Location = new System.Drawing.Point(201, 19);
            this.BTN_MACRO_EDITOR.Name = "BTN_MACRO_EDITOR";
            this.BTN_MACRO_EDITOR.Size = new System.Drawing.Size(148, 31);
            this.BTN_MACRO_EDITOR.TabIndex = 3;
            this.BTN_MACRO_EDITOR.Text = "打开宏编辑器";
            this.BTN_MACRO_EDITOR.UseVisualStyleBackColor = true;
            this.BTN_MACRO_EDITOR.Click += new System.EventHandler(this.BTN_MACRO_EDITOR_Click);
            // 
            // AddCraftProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 565);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BTN_SAVE);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCraftProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加/编辑制作工序";
            this.Load += new System.EventHandler(this.AddCraftProcess_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CONTROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CRAFTSMANSHIP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_EDIT_TARGETS;
        private System.Windows.Forms.ComboBox CBX_CRAFT_TARGET;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_CRAFTSMANSHIP;
        private System.Windows.Forms.NumericUpDown NUD_CONTROL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TBX_PROCESS;
        private System.Windows.Forms.RadioButton RBT_SIMULATOR_PROCESS;
        private System.Windows.Forms.RadioButton RBT_MACRO;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TBX_PROCESS_NAME;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox CBX_LOAD_PROCESS;
        private System.Windows.Forms.Button BTN_MACRO_EDITOR;
    }
}