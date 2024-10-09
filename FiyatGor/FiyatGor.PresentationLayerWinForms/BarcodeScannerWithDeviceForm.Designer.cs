using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FiyatGor.PresentationLayerWinForms
{
    partial class BarcodeScannerWithDeviceForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblBarkod;
        private Label lblAd;
        private Label lblSFiyat;
        private Label lblBakiye;
        private Button button1;
        private Panel panel1;
        private Panel panel2;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeScannerWithDeviceForm));
            lblBarkod = new Label();
            lblAd = new Label();
            lblSFiyat = new Label();
            lblBakiye = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBarkod
            // 
            lblBarkod.AutoSize = true;
            lblBarkod.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBarkod.ForeColor = SystemColors.ControlText;
            lblBarkod.Location = new Point(57, 264);
            lblBarkod.Name = "lblBarkod";
            lblBarkod.Size = new Size(136, 20);
            lblBarkod.TabIndex = 0;
            lblBarkod.Text = "Barkod Numarası: ";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAd.ForeColor = SystemColors.ControlText;
            lblAd.Location = new Point(57, 342);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(36, 20);
            lblAd.TabIndex = 1;
            lblAd.Text = "Ad: ";
            // 
            // lblSFiyat
            // 
            lblSFiyat.AutoSize = true;
            lblSFiyat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSFiyat.ForeColor = SystemColors.ControlText;
            lblSFiyat.Location = new Point(57, 422);
            lblSFiyat.Name = "lblSFiyat";
            lblSFiyat.Size = new Size(89, 20);
            lblSFiyat.TabIndex = 2;
            lblSFiyat.Text = "Satış Fiyatı: ";
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBakiye.ForeColor = SystemColors.ControlText;
            lblBakiye.Location = new Point(57, 505);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(62, 20);
            lblBakiye.TabIndex = 3;
            lblBakiye.Text = "Bakiye: ";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(964, 639);
            button1.Name = "button1";
            button1.Size = new Size(164, 53);
            button1.TabIndex = 5;
            button1.Text = "Ana Sayfaya Dön";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1154, 99);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(381, 20);
            label1.Name = "label1";
            label1.Size = new Size(521, 62);
            label1.TabIndex = 3;
            label1.Text = "Barkod Okuma Sayfası";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 715);
            panel2.Name = "panel2";
            panel2.Size = new Size(1154, 36);
            panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(143, 157);
            label2.Name = "label2";
            label2.Size = new Size(181, 38);
            label2.TabIndex = 35;
            label2.Text = "Ürün Bilgileri";
            // 
            // BarcodeScannerWithDeviceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1154, 751);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(lblBakiye);
            Controls.Add(lblSFiyat);
            Controls.Add(lblAd);
            Controls.Add(lblBarkod);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BarcodeScannerWithDeviceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Barkod Okuma";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}
