using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Win32;
using System.Text.RegularExpressions;


namespace Rainbow_word_memory
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            Form_About form_about = new Form_About();
            form_about.ShowDialog();
        }

        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void ToolStripMenuItem_Help_Look_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"http\shell\open\command\");
            string web_browser = key.GetValue("").ToString();
            Regex reg = new Regex("\"([^\"]+)\"");
            MatchCollection matchs = reg.Matches(web_browser);
            string filename = "";
            if (matchs.Count > 0)
            {
                filename = matchs[0].Groups[1].Value;
                System.Diagnostics.Process.Start(filename,"http://www.rainbowsoftware.com/");
            }
        }

        private void ToolStripMenuItem_Version_Check_Up_Click(object sender, EventArgs e)
        {

        }




    }
}
