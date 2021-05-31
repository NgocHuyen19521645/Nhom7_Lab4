using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient webClient = new WebClient();
                Stream res = webClient.OpenRead(this.textBox1.Text);
                string content = webClient.DownloadString(this.textBox1.Text);
                this.richTextBox1.Text = content;
                webClient.DownloadFile(this.textBox1.Text, this.textBox2.Text);             
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
