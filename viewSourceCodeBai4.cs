using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class viewSourceCodeBai4 : Form
    {
        public viewSourceCodeBai4(string response)
        {
            InitializeComponent();
            richTextBox1.Text = response;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
