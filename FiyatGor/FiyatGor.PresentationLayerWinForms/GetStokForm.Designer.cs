namespace FiyatGor.PresentationLayerWinForms
{
    partial class GetStokForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtBarcode;
        private Button btnGetDetails;
        private Label lblBarcode;
        private Label lblAd;
        private Label lblBakiye;
        private Label lblSFiyat;
        private TextBox txtAd;
        private TextBox txtBakiye;
        private TextBox txtSFiyat;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetStokForm));
            txtBarcode = new TextBox();
            btnGetDetails = new Button();
            lblBarcode = new Label();
            lblAd = new Label();
            lblBakiye = new Label();
            lblSFiyat = new Label();
            txtAd = new TextBox();
            txtBakiye = new TextBox();
            txtSFiyat = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(200, 200);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(370, 27);
            txtBarcode.TabIndex = 0;
            // 
            // btnGetDetails
            // 
            btnGetDetails.BackColor = Color.Teal;
            btnGetDetails.FlatAppearance.BorderColor = Color.Teal;
            btnGetDetails.FlatStyle = FlatStyle.Flat;
            btnGetDetails.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGetDetails.ForeColor = Color.White;
            btnGetDetails.Location = new Point(455, 268);
            btnGetDetails.Name = "btnGetDetails";
            btnGetDetails.Size = new Size(115, 36);
            btnGetDetails.TabIndex = 1;
            btnGetDetails.Text = "Bilgileri Getir";
            btnGetDetails.UseVisualStyleBackColor = false;
            btnGetDetails.Click += btnGetDetails_Click;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBarcode.Location = new Point(36, 207);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(128, 20);
            lblBarcode.TabIndex = 2;
            lblBarcode.Text = "Barkod Numarası";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAd.Location = new Point(717, 268);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 20);
            lblAd.TabIndex = 3;
            lblAd.Text = "Ad";
            lblAd.Click += lblAd_Click;
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBakiye.Location = new Point(717, 343);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(54, 20);
            lblBakiye.TabIndex = 4;
            lblBakiye.Text = "Bakiye";
            // 
            // lblSFiyat
            // 
            lblSFiyat.AutoSize = true;
            lblSFiyat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSFiyat.ForeColor = SystemColors.ControlText;
            lblSFiyat.Location = new Point(717, 419);
            lblSFiyat.Name = "lblSFiyat";
            lblSFiyat.Size = new Size(81, 20);
            lblSFiyat.TabIndex = 5;
            lblSFiyat.Text = "Satış Fiyatı";
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.White;
            txtAd.Location = new Point(814, 261);
            txtAd.Name = "txtAd";
            txtAd.ReadOnly = true;
            txtAd.Size = new Size(260, 27);
            txtAd.TabIndex = 6;
            // 
            // txtBakiye
            // 
            txtBakiye.BackColor = Color.White;
            txtBakiye.Location = new Point(814, 336);
            txtBakiye.Name = "txtBakiye";
            txtBakiye.ReadOnly = true;
            txtBakiye.Size = new Size(260, 27);
            txtBakiye.TabIndex = 7;
            // 
            // txtSFiyat
            // 
            txtSFiyat.BackColor = Color.White;
            txtSFiyat.Location = new Point(814, 412);
            txtSFiyat.Name = "txtSFiyat";
            txtSFiyat.ReadOnly = true;
            txtSFiyat.Size = new Size(260, 27);
            txtSFiyat.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 107);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(340, 22);
            label1.Name = "label1";
            label1.Size = new Size(443, 62);
            label1.TabIndex = 5;
            label1.Text = "Ürün Detay Sayfası";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 578);
            panel2.Name = "panel2";
            panel2.Size = new Size(1130, 26);
            panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(717, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatAppearance.BorderColor = Color.Teal;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(431, 463);
            button2.Name = "button2";
            button2.Size = new Size(139, 38);
            button2.TabIndex = 23;
            button2.Text = "Ana Sayfaya Dön";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(798, 189);
            label2.Name = "label2";
            label2.Size = new Size(181, 38);
            label2.TabIndex = 39;
            label2.Text = "Ürün Bilgileri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(36, 383);
            label3.Name = "label3";
            label3.Size = new Size(534, 20);
            label3.TabIndex = 40;
            label3.Text = "Lütfen bilgilerini görüntülemek istediğiniz ürüne ait barkod numarasını girin.";
            label3.Click += label3_Click;
            // 
            // GetStokForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(1130, 604);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtSFiyat);
            Controls.Add(txtBakiye);
            Controls.Add(txtAd);
            Controls.Add(lblSFiyat);
            Controls.Add(lblBakiye);
            Controls.Add(lblAd);
            Controls.Add(lblBarcode);
            Controls.Add(btnGetDetails);
            Controls.Add(txtBarcode);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GetStokForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Bilgileri";
            Load += GetStokForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
    }
}
