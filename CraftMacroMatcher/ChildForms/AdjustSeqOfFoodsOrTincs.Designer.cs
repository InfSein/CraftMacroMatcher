namespace CraftMacroMatcher.ChildForms
{
    partial class AdjustSeqOfFoodsOrTincs
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
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBX_TARGETS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN_SAVE.Location = new System.Drawing.Point(357, 375);
            this.BTN_SAVE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(102, 43);
            this.BTN_SAVE.TabIndex = 3;
            this.BTN_SAVE.Text = "保存";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBX_TARGETS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(447, 354);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入食物列表";
            // 
            // TBX_TARGETS
            // 
            this.TBX_TARGETS.Location = new System.Drawing.Point(17, 103);
            this.TBX_TARGETS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBX_TARGETS.Multiline = true;
            this.TBX_TARGETS.Name = "TBX_TARGETS";
            this.TBX_TARGETS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBX_TARGETS.Size = new System.Drawing.Size(414, 232);
            this.TBX_TARGETS.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "重命名或删除任意一行即会删除对应食物";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "每行一个 只能调整顺序 不可用于新增\r\n此列表指定的顺序保存后也会改变其他界面的顺序";
            // 
            // AdjustSeqOfFoodsOrTincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 432);
            this.Controls.Add(this.BTN_SAVE);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdjustSeqOfFoodsOrTincs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "调整顺序";
            this.Load += new System.EventHandler(this.AdjustSeqOfFoodsOrTincs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBX_TARGETS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}