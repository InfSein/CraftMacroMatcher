namespace CraftMacroMatcher.ChildForms
{
    partial class ExportMacro
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
            this.CBX_LAN = new System.Windows.Forms.ComboBox();
            this.BTN_COPY_1 = new System.Windows.Forms.Button();
            this.BTN_COPY_2 = new System.Windows.Forms.Button();
            this.BTN_COPY_4 = new System.Windows.Forms.Button();
            this.BTN_COPY_3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBX_LAN);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择客户端语言";
            // 
            // CBX_LAN
            // 
            this.CBX_LAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_LAN.FormattingEnabled = true;
            this.CBX_LAN.Items.AddRange(new object[] {
            "中文",
            "日语",
            "英语"});
            this.CBX_LAN.Location = new System.Drawing.Point(26, 26);
            this.CBX_LAN.Name = "CBX_LAN";
            this.CBX_LAN.Size = new System.Drawing.Size(191, 28);
            this.CBX_LAN.TabIndex = 0;
            // 
            // BTN_COPY_1
            // 
            this.BTN_COPY_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN_COPY_1.Location = new System.Drawing.Point(12, 86);
            this.BTN_COPY_1.Name = "BTN_COPY_1";
            this.BTN_COPY_1.Size = new System.Drawing.Size(115, 39);
            this.BTN_COPY_1.TabIndex = 1;
            this.BTN_COPY_1.Text = "复制宏#1";
            this.BTN_COPY_1.UseVisualStyleBackColor = true;
            this.BTN_COPY_1.Click += new System.EventHandler(this.BTN_COPY_1_Click);
            // 
            // BTN_COPY_2
            // 
            this.BTN_COPY_2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN_COPY_2.Location = new System.Drawing.Point(138, 86);
            this.BTN_COPY_2.Name = "BTN_COPY_2";
            this.BTN_COPY_2.Size = new System.Drawing.Size(115, 39);
            this.BTN_COPY_2.TabIndex = 2;
            this.BTN_COPY_2.Text = "复制宏#2";
            this.BTN_COPY_2.UseVisualStyleBackColor = true;
            this.BTN_COPY_2.Click += new System.EventHandler(this.BTN_COPY_2_Click);
            // 
            // BTN_COPY_4
            // 
            this.BTN_COPY_4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN_COPY_4.Location = new System.Drawing.Point(138, 131);
            this.BTN_COPY_4.Name = "BTN_COPY_4";
            this.BTN_COPY_4.Size = new System.Drawing.Size(115, 39);
            this.BTN_COPY_4.TabIndex = 4;
            this.BTN_COPY_4.Text = "复制宏#4";
            this.BTN_COPY_4.UseVisualStyleBackColor = true;
            this.BTN_COPY_4.Click += new System.EventHandler(this.BTN_COPY_4_Click);
            // 
            // BTN_COPY_3
            // 
            this.BTN_COPY_3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN_COPY_3.Location = new System.Drawing.Point(12, 131);
            this.BTN_COPY_3.Name = "BTN_COPY_3";
            this.BTN_COPY_3.Size = new System.Drawing.Size(115, 39);
            this.BTN_COPY_3.TabIndex = 3;
            this.BTN_COPY_3.Text = "复制宏#3";
            this.BTN_COPY_3.UseVisualStyleBackColor = true;
            this.BTN_COPY_3.Click += new System.EventHandler(this.BTN_COPY_3_Click);
            // 
            // ExportMacro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 180);
            this.Controls.Add(this.BTN_COPY_4);
            this.Controls.Add(this.BTN_COPY_3);
            this.Controls.Add(this.BTN_COPY_2);
            this.Controls.Add(this.BTN_COPY_1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExportMacro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExportMacro";
            this.Load += new System.EventHandler(this.ExportMacro_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBX_LAN;
        private System.Windows.Forms.Button BTN_COPY_1;
        private System.Windows.Forms.Button BTN_COPY_2;
        private System.Windows.Forms.Button BTN_COPY_4;
        private System.Windows.Forms.Button BTN_COPY_3;
    }
}