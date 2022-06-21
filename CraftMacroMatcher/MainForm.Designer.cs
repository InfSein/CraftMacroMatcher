namespace CraftMacroMatcher
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SLAB_TIP = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.配置数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于本作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NUD_Craftsmanship = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBX_CRAFT_TARGET = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CBX_IS_MASTER = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NUD_CP = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NUD_Control = new System.Windows.Forms.NumericUpDown();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.添加工序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Craftsmanship)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CP)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Control)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SLAB_TIP});
            this.toolStrip1.Location = new System.Drawing.Point(0, 263);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(770, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SLAB_TIP
            // 
            this.SLAB_TIP.Name = "SLAB_TIP";
            this.SLAB_TIP.Size = new System.Drawing.Size(84, 22);
            this.SLAB_TIP.Text = "初始化成功";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置数据ToolStripMenuItem,
            this.关于本作ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 配置数据ToolStripMenuItem
            // 
            this.配置数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加工序ToolStripMenuItem});
            this.配置数据ToolStripMenuItem.Name = "配置数据ToolStripMenuItem";
            this.配置数据ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.配置数据ToolStripMenuItem.Text = "配置数据";
            // 
            // 关于本作ToolStripMenuItem
            // 
            this.关于本作ToolStripMenuItem.Name = "关于本作ToolStripMenuItem";
            this.关于本作ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.关于本作ToolStripMenuItem.Text = "关于本作";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NUD_Craftsmanship);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(6, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "作业精度";
            // 
            // NUD_Craftsmanship
            // 
            this.NUD_Craftsmanship.Location = new System.Drawing.Point(25, 24);
            this.NUD_Craftsmanship.Name = "NUD_Craftsmanship";
            this.NUD_Craftsmanship.Size = new System.Drawing.Size(81, 27);
            this.NUD_Craftsmanship.TabIndex = 0;
            this.NUD_Craftsmanship.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUD_Craftsmanship.ValueChanged += new System.EventHandler(this.NUD_Craftsmanship_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBX_CRAFT_TARGET);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 60);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "制作目标";
            // 
            // CBX_CRAFT_TARGET
            // 
            this.CBX_CRAFT_TARGET.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_CRAFT_TARGET.FormattingEnabled = true;
            this.CBX_CRAFT_TARGET.Location = new System.Drawing.Point(15, 23);
            this.CBX_CRAFT_TARGET.Name = "CBX_CRAFT_TARGET";
            this.CBX_CRAFT_TARGET.Size = new System.Drawing.Size(216, 28);
            this.CBX_CRAFT_TARGET.TabIndex = 0;
            this.CBX_CRAFT_TARGET.SelectedIndexChanged += new System.EventHandler(this.CBX_CRAFT_TARGET_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(12, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 156);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "自身属性";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CBX_IS_MASTER);
            this.groupBox6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(125, 91);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(113, 59);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "专家?";
            // 
            // CBX_IS_MASTER
            // 
            this.CBX_IS_MASTER.AutoSize = true;
            this.CBX_IS_MASTER.Cursor = System.Windows.Forms.Cursors.Help;
            this.CBX_IS_MASTER.Location = new System.Drawing.Point(25, 24);
            this.CBX_IS_MASTER.Name = "CBX_IS_MASTER";
            this.CBX_IS_MASTER.Size = new System.Drawing.Size(46, 24);
            this.CBX_IS_MASTER.TabIndex = 0;
            this.CBX_IS_MASTER.Text = "是";
            this.toolTip1.SetToolTip(this.CBX_IS_MASTER, "仅用于工序判断,三维请按照面板属性填写");
            this.CBX_IS_MASTER.UseVisualStyleBackColor = true;
            this.CBX_IS_MASTER.CheckedChanged += new System.EventHandler(this.CBX_IS_MASTER_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.NUD_CP);
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(125, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(113, 59);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "制作力";
            // 
            // NUD_CP
            // 
            this.NUD_CP.Location = new System.Drawing.Point(25, 24);
            this.NUD_CP.Name = "NUD_CP";
            this.NUD_CP.Size = new System.Drawing.Size(81, 27);
            this.NUD_CP.TabIndex = 0;
            this.NUD_CP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUD_CP.ValueChanged += new System.EventHandler(this.NUD_CP_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NUD_Control);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(6, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(113, 59);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "加工精度";
            // 
            // NUD_Control
            // 
            this.NUD_Control.Location = new System.Drawing.Point(25, 24);
            this.NUD_Control.Name = "NUD_Control";
            this.NUD_Control.Size = new System.Drawing.Size(81, 27);
            this.NUD_Control.TabIndex = 0;
            this.NUD_Control.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUD_Control.ValueChanged += new System.EventHandler(this.NUD_Control_ValueChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.Location = new System.Drawing.Point(262, 31);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(496, 221);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "查看工序";
            // 
            // 添加工序ToolStripMenuItem
            // 
            this.添加工序ToolStripMenuItem.Name = "添加工序ToolStripMenuItem";
            this.添加工序ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.添加工序ToolStripMenuItem.Text = "添加工序";
            this.添加工序ToolStripMenuItem.Click += new System.EventHandler(this.添加工序ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 288);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "能工巧匠配宏器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Craftsmanship)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CP)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Control)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel SLAB_TIP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 配置数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于本作ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NUD_Craftsmanship;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CBX_CRAFT_TARGET;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox CBX_IS_MASTER;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown NUD_CP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown NUD_Control;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem 添加工序ToolStripMenuItem;
    }
}

