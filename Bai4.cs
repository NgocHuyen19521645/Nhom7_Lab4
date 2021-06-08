using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Text.RegularExpressions;
#pragma warning disable CS0246 // The type or namespace name 'HtmlAgilityPack' could not be found (are you missing a using directive or an assembly reference?)
using HtmlAgilityPack;
#pragma warning restore CS0246 // The type or namespace name 'HtmlAgilityPack' could not be found (are you missing a using directive or an assembly reference?)

namespace WindowsFormsApp1
{
    public partial class Bai4 : Form
    {
        WebBrowser wb;
        List<string> ImageList = new List<string>();
        public Bai4()
        {
            InitializeComponent();
            wb = new WebBrowser();
            wb.Width = 890;
            wb.Height = 400;
            panel1.Controls.Add(wb);
        }
        public void GetAllImages(string path)
        {

            WebClient x = new WebClient();
            string source = x.DownloadString(toolStripComboBox1.Text);
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(source);
            HtmlNodeCollection imgs = document.DocumentNode.SelectNodes("//img[@src]");
            if (imgs == null)
                return;
            int k = 0;
            foreach (HtmlNode img in imgs)
            {
                if (img.Attributes["src"].Value != null)
                {
                    try
                    {
                        HtmlAttribute src = img.Attributes["src"];
                        ImageList.Add(img.Attributes["src"].Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        k++;
                    }
                }
            }

            foreach (var e in ImageList)
            {
                try
                {
                    string filepath = e.ToString();

                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(filepath, path + "\\" + "img_" + ".html");
                }
                catch
                {

                }
            }

        }
        private void downloaddata(string path)
        {

            WebClient webcl = new WebClient();
            webcl.DownloadFile(toolStripComboBox1.Text, path + "/" + "index.html");
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập URL", "WARNING");
                return;
            }
            try
            {
                WebClient myClient = new WebClient();
                string link = toolStripComboBox1.Text;
                string response = myClient.DownloadString(link);
            }
            catch
            {
                MessageBox.Show("URL không hợp lệ, vui lòng kiểm tra lại", "WARNING");
            }

            FolderBrowserDialog fb = new FolderBrowserDialog();
            string path = "";
            if (fb.ShowDialog() == DialogResult.OK)
            {

                path = fb.SelectedPath;

            }
            try
            {
                downloaddata(path);
                GetAllImages(path);
                MessageBox.Show("Download thành công", "Message");
            }
            catch
            {
                MessageBox.Show("Download không thành công", "Message");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (toolStripComboBox1.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập URL", "WARNING");
                    return;
                }
                WebClient myClient = new WebClient();
                string link = toolStripComboBox1.Text;
                string response = myClient.DownloadString(link);
                Form a = new viewSourceCodeBai4(response);
                a.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Link không hợp lệ, vui lòng điền 'http://' trước đường link hoặc kiêm tra lại", "WARNING");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (toolStripComboBox1.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập URL", "WARNING");
                    return;
                }
                string link = toolStripComboBox1.Text;
                wb.Navigate(link);
            }
            catch
            {
                MessageBox.Show("Link không hợp lệ,thử lại", "WARNING");
            }
        }

        private void toolStrip1_ItemClicked(object sender, EventArgs e)
        {

        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
