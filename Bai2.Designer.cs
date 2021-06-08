
namespace WindowsFormsApp1
{
    partial class Bai2
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
            this.btnPost = new System.Windows.Forms.Button();
            this.rtbResponse = new System.Windows.Forms.RichTextBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPost.Location = new System.Drawing.Point(667, 20);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(98, 50);
            this.btnPost.TabIndex = 0;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // rtbResponse
            // 
            this.rtbResponse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbResponse.Location = new System.Drawing.Point(65, 124);
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.Size = new System.Drawing.Size(700, 264);
            this.rtbResponse.TabIndex = 1;
            this.rtbResponse.Text = "";
            // 
            // tbURL
            // 
            this.tbURL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbURL.Location = new System.Drawing.Point(66, 20);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(568, 26);
            this.tbURL.TabIndex = 2;
            // 
            // tbContent
            // 
            this.tbContent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbContent.Location = new System.Drawing.Point(65, 60);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(568, 26);
            this.tbContent.TabIndex = 3;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.rtbResponse);
            this.Controls.Add(this.btnPost);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.RichTextBox rtbResponse;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.TextBox tbContent;
    }
}