namespace Rainbow_word_memory
{
    partial class Form_Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Look = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Save_For = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Help_Look = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Version_Check_Up = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Start,
            this.ToolStripMenuItem_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Start
            // 
            this.ToolStripMenuItem_Start.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Look,
            this.ToolStripMenuItem_Save,
            this.ToolStripMenuItem_Save_For,
            this.ToolStripMenuItem_Exit});
            this.ToolStripMenuItem_Start.Name = "ToolStripMenuItem_Start";
            this.ToolStripMenuItem_Start.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_Start.Text = "开始";
            // 
            // ToolStripMenuItem_Look
            // 
            this.ToolStripMenuItem_Look.Name = "ToolStripMenuItem_Look";
            this.ToolStripMenuItem_Look.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItem_Look.Text = "查看";
            // 
            // ToolStripMenuItem_Save
            // 
            this.ToolStripMenuItem_Save.Name = "ToolStripMenuItem_Save";
            this.ToolStripMenuItem_Save.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItem_Save.Text = "保存";
            // 
            // ToolStripMenuItem_Save_For
            // 
            this.ToolStripMenuItem_Save_For.Name = "ToolStripMenuItem_Save_For";
            this.ToolStripMenuItem_Save_For.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItem_Save_For.Text = "另存为";
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItem_Exit.Text = "关闭";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
            // 
            // ToolStripMenuItem_Help
            // 
            this.ToolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Help_Look,
            this.ToolStripMenuItem_Version_Check_Up,
            this.ToolStripMenuItem_About});
            this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
            this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_Help.Text = "帮助";
            // 
            // ToolStripMenuItem_Help_Look
            // 
            this.ToolStripMenuItem_Help_Look.Name = "ToolStripMenuItem_Help_Look";
            this.ToolStripMenuItem_Help_Look.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Help_Look.Text = "查看帮助";
            this.ToolStripMenuItem_Help_Look.Click += new System.EventHandler(this.ToolStripMenuItem_Help_Look_Click);
            // 
            // ToolStripMenuItem_Version_Check_Up
            // 
            this.ToolStripMenuItem_Version_Check_Up.Name = "ToolStripMenuItem_Version_Check_Up";
            this.ToolStripMenuItem_Version_Check_Up.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Version_Check_Up.Text = "版本升级";
            this.ToolStripMenuItem_Version_Check_Up.Click += new System.EventHandler(this.ToolStripMenuItem_Version_Check_Up_Click);
            // 
            // ToolStripMenuItem_About
            // 
            this.ToolStripMenuItem_About.Name = "ToolStripMenuItem_About";
            this.ToolStripMenuItem_About.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_About.Text = "关于";
            this.ToolStripMenuItem_About.Click += new System.EventHandler(this.ToolStripMenuItem_About_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 490);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.Text = "Rainbow words memory";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Start;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Look;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Save_For;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help_Look;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Version_Check_Up;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_About;
    }
}

