namespace CraftMacroMatcher.ChildForms
{
    partial class AddTinc
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CBX_LOAD_TINC = new System.Windows.Forms.ComboBox();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBX_CP_MAX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBX_CP_PERCENT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBX_CONTROL_MAX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBX_CONTROL_PERCENT = new System.Windows.Forms.TextBox();
            this.TBX_CRAFTSM_MAX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBX_CRAFTSM_PERCENT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CBX_ISHQ = new System.Windows.Forms.CheckBox();
            this.TBX_TINC_NAME = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CBX_LOAD_TINC);
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(376, 68);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "读取已有药水";
            // 
            // CBX_LOAD_TINC
            // 
            this.CBX_LOAD_TINC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_LOAD_TINC.FormattingEnabled = true;
            this.CBX_LOAD_TINC.Location = new System.Drawing.Point(25, 26);
            this.CBX_LOAD_TINC.Name = "CBX_LOAD_TINC";
            this.CBX_LOAD_TINC.Size = new System.Drawing.Size(324, 28);
            this.CBX_LOAD_TINC.TabIndex = 0;
            this.CBX_LOAD_TINC.SelectedIndexChanged += new System.EventHandler(this.CBX_LOAD_TINC_SelectedIndexChanged);
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN_SAVE.Location = new System.Drawing.Point(286, 304);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(102, 40);
            this.BTN_SAVE.TabIndex = 11;
            this.BTN_SAVE.Text = "保存";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TBX_CP_MAX);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TBX_CP_PERCENT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TBX_CONTROL_MAX);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TBX_CONTROL_PERCENT);
            this.groupBox2.Controls.Add(this.TBX_CRAFTSM_MAX);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TBX_CRAFTSM_PERCENT);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 141);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "药水效果(不填默认为0)";
            // 
            // TBX_CP_MAX
            // 
            this.TBX_CP_MAX.Location = new System.Drawing.Point(248, 96);
            this.TBX_CP_MAX.Name = "TBX_CP_MAX";
            this.TBX_CP_MAX.Size = new System.Drawing.Size(62, 27);
            this.TBX_CP_MAX.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "%，最多";
            // 
            // TBX_CP_PERCENT
            // 
            this.TBX_CP_PERCENT.Location = new System.Drawing.Point(126, 96);
            this.TBX_CP_PERCENT.Name = "TBX_CP_PERCENT";
            this.TBX_CP_PERCENT.Size = new System.Drawing.Size(43, 27);
            this.TBX_CP_PERCENT.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "制作力增加";
            // 
            // TBX_CONTROL_MAX
            // 
            this.TBX_CONTROL_MAX.Location = new System.Drawing.Point(248, 62);
            this.TBX_CONTROL_MAX.Name = "TBX_CONTROL_MAX";
            this.TBX_CONTROL_MAX.Size = new System.Drawing.Size(62, 27);
            this.TBX_CONTROL_MAX.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "%，最多";
            // 
            // TBX_CONTROL_PERCENT
            // 
            this.TBX_CONTROL_PERCENT.Location = new System.Drawing.Point(126, 62);
            this.TBX_CONTROL_PERCENT.Name = "TBX_CONTROL_PERCENT";
            this.TBX_CONTROL_PERCENT.Size = new System.Drawing.Size(43, 27);
            this.TBX_CONTROL_PERCENT.TabIndex = 6;
            // 
            // TBX_CRAFTSM_MAX
            // 
            this.TBX_CRAFTSM_MAX.Location = new System.Drawing.Point(248, 30);
            this.TBX_CRAFTSM_MAX.Name = "TBX_CRAFTSM_MAX";
            this.TBX_CRAFTSM_MAX.Size = new System.Drawing.Size(62, 27);
            this.TBX_CRAFTSM_MAX.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "%，最多";
            // 
            // TBX_CRAFTSM_PERCENT
            // 
            this.TBX_CRAFTSM_PERCENT.Location = new System.Drawing.Point(126, 30);
            this.TBX_CRAFTSM_PERCENT.Name = "TBX_CRAFTSM_PERCENT";
            this.TBX_CRAFTSM_PERCENT.Size = new System.Drawing.Size(43, 27);
            this.TBX_CRAFTSM_PERCENT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "加工精度增加";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "作业精度增加";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CBX_ISHQ);
            this.groupBox4.Controls.Add(this.TBX_TINC_NAME);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(12, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(376, 65);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "药水名称";
            // 
            // CBX_ISHQ
            // 
            this.CBX_ISHQ.AutoSize = true;
            this.CBX_ISHQ.Location = new System.Drawing.Point(304, 28);
            this.CBX_ISHQ.Name = "CBX_ISHQ";
            this.CBX_ISHQ.Size = new System.Drawing.Size(55, 24);
            this.CBX_ISHQ.TabIndex = 1;
            this.CBX_ISHQ.Text = "HQ";
            this.CBX_ISHQ.UseVisualStyleBackColor = true;
            // 
            // TBX_TINC_NAME
            // 
            this.TBX_TINC_NAME.Location = new System.Drawing.Point(25, 26);
            this.TBX_TINC_NAME.Name = "TBX_TINC_NAME";
            this.TBX_TINC_NAME.Size = new System.Drawing.Size(273, 27);
            this.TBX_TINC_NAME.TabIndex = 0;
            // 
            // AddTinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 353);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.BTN_SAVE);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "AddTinc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加/编辑药水";
            this.Load += new System.EventHandler(this.AddTinc_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox CBX_LOAD_TINC;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TBX_CP_MAX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBX_CP_PERCENT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBX_CONTROL_MAX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBX_CONTROL_PERCENT;
        private System.Windows.Forms.TextBox TBX_CRAFTSM_MAX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBX_CRAFTSM_PERCENT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox CBX_ISHQ;
        private System.Windows.Forms.TextBox TBX_TINC_NAME;
    }
}