namespace Rainbow_word_memory
{
    partial class Form_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_About));
            this.textBox_About = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_About
            // 
            this.textBox_About.AcceptsReturn = true;
            resources.ApplyResources(this.textBox_About, "textBox_About");
            this.textBox_About.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_About.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_About.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_About.Name = "textBox_About";
            this.textBox_About.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form_About
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_About);
            this.MaximizeBox = false;
            this.Name = "Form_About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_About;
    }
}