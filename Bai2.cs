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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Post(string url)
        {
            try
            {
                WebRequest req = WebRequest.Create(url);
            req.Method = "POST";
            byte[] postdata = Encoding.ASCII.GetBytes(tbContent.Text);

            Stream streamdata = req.GetRequestStream();
            streamdata.Write(postdata, 0, postdata.Length);
            streamdata.Close();

            WebResponse res = req.GetResponse();
            using (Stream dataStream = res.GetResponseStream())
            {
                StreamReader sr = new StreamReader(dataStream);
                string responseFromServer = sr.ReadToEnd();
                rtbResponse.Text = responseFromServer;
            }
            }
            catch
            {
                MessageBox.Show("Sai URL!!");
                return ;
            }

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Post(tbURL.Text);
        }


    }
}
