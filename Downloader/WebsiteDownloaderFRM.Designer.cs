
namespace Downloader
{
    partial class WebsiteDownloaderFRM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.downloadBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downloadBTN
            // 
            this.downloadBTN.AllowDrop = true;
            this.downloadBTN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.downloadBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downloadBTN.Location = new System.Drawing.Point(22, 22);
            this.downloadBTN.Name = "downloadBTN";
            this.downloadBTN.Size = new System.Drawing.Size(125, 47);
            this.downloadBTN.TabIndex = 0;
            this.downloadBTN.Text = "Download Aysnc";
            this.downloadBTN.UseVisualStyleBackColor = true;
            this.downloadBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(22, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(776, 332);
            this.textBox1.TabIndex = 1;
            // 
            // cancelBTN
            // 
            this.cancelBTN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBTN.Location = new System.Drawing.Point(153, 22);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(125, 47);
            this.cancelBTN.TabIndex = 2;
            this.cancelBTN.Text = "Cancel Operation";
            this.cancelBTN.UseVisualStyleBackColor = false;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 470);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.downloadBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Download Websites";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadBTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cancelBTN;
    }
}

