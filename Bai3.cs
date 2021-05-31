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
                WebClient webClient = new WebClient(); // Create a webClient
                string url = this.textBox1.Text;
                Stream res = webClient.OpenRead(url);  //Read Content to a Stream
                string content = webClient.DownloadString(url); // Download HTML from URL
                this.richTextBox1.Text = content; 
                string fileName = this.textBox2.Text;
                webClient.DownloadFile(url, fileName);   //Get Web content to File       
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error ); //Catch Error
            }
        }
    }
}
