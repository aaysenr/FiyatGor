namespace FiyatGor.PresentationLayerWinForms
{
    partial class AddStokForm
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStokForm));
            txtBarkod = new TextBox();
            txtAd = new TextBox();
            txtBakiye = new TextBox();
            txtSFiyat = new TextBox();
            dataGridView = new DataGridView();
            BarkodColumn = new DataGridViewTextBoxColumn();
            AdColumn = new DataGridViewTextBoxColumn();
            BakiyeColumn = new DataGridViewTextBoxColumn();
            SFiyatColumn = new DataGridViewTextBoxColumn();
            btnEkle = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblAd = new Label();
            lblBakiye = new Label();
            lblSFiyat = new Label();
            lblBarcode = new Label();
            button2 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(209, 208);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.PlaceholderText = "Barkod Numarası";
            txtBarkod.Size = new Size(200, 27);
            txtBarkod.TabIndex = 0;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(209, 267);
            txtAd.Name = "txtAd";
            txtAd.PlaceholderText = "Ad";
            txtAd.Size = new Size(200, 27);
            txtAd.TabIndex = 1;
            // 
            // txtBakiye
            // 
            txtBakiye.Location = new Point(209, 322);
            txtBakiye.Name = "txtBakiye";
            txtBakiye.PlaceholderText = "Bakiye";
            txtBakiye.Size = new Size(200, 27);
            txtBakiye.TabIndex = 2;
            // 
            // txtSFiyat
            // 
            txtSFiyat.Location = new Point(209, 376);
            txtSFiyat.Name = "txtSFiyat";
            txtSFiyat.PlaceholderText = "Satış Fiyatı";
            txtSFiyat.Size = new Size(200, 27);
            txtSFiyat.TabIndex = 3;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.Teal;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { BarkodColumn, AdColumn, BakiyeColumn, SFiyatColumn });
            dataGridView.Location = new Point(620, 129);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 24;
            dataGridView.Size = new Size(553, 438);
            dataGridView.TabIndex = 5;
            // 
            // BarkodColumn
            // 
            BarkodColumn.HeaderText = "Barkod Numarası";
            BarkodColumn.MinimumWidth = 6;
            BarkodColumn.Name = "BarkodColumn";
            BarkodColumn.Width = 125;
            // 
            // AdColumn
            // 
            AdColumn.HeaderText = "Ad";
            AdColumn.MinimumWidth = 6;
            AdColumn.Name = "AdColumn";
            AdColumn.Width = 125;
            // 
            // BakiyeColumn
            // 
            BakiyeColumn.HeaderText = "Bakiye";
            BakiyeColumn.MinimumWidth = 6;
            BakiyeColumn.Name = "BakiyeColumn";
            BakiyeColumn.Width = 125;
            // 
            // SFiyatColumn
            // 
            SFiyatColumn.HeaderText = "Satış Fiyatı";
            SFiyatColumn.MinimumWidth = 6;
            SFiyatColumn.Name = "SFiyatColumn";
            SFiyatColumn.Width = 125;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Teal;
            btnEkle.FlatAppearance.BorderColor = Color.Teal;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(310, 438);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(99, 34);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(136, 136);
            label2.Name = "label2";
            label2.Size = new Size(181, 38);
            label2.TabIndex = 39;
            label2.Text = "Ürün Bilgileri";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAd.Location = new Point(39, 274);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 20);
            lblAd.TabIndex = 41;
            lblAd.Text = "Ad";
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBakiye.Location = new Point(39, 329);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(54, 20);
            lblBakiye.TabIndex = 42;
            lblBakiye.Text = "Bakiye";
            // 
            // lblSFiyat
            // 
            lblSFiyat.AutoSize = true;
            lblSFiyat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSFiyat.ForeColor = SystemColors.ControlText;
            lblSFiyat.Location = new Point(39, 383);
            lblSFiyat.Name = "lblSFiyat";
            lblSFiyat.Size = new Size(81, 20);
            lblSFiyat.TabIndex = 43;
            lblSFiyat.Text = "Satış Fiyatı";
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBarcode.Location = new Point(39, 215);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(128, 20);
            lblBarcode.TabIndex = 44;
            lblBarcode.Text = "Barkod Numarası";
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatAppearance.BorderColor = Color.Teal;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(268, 547);
            button2.Name = "button2";
            button2.Size = new Size(141, 35);
            button2.TabIndex = 45;
            button2.Text = "Ana Sayfaya Dön";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1294, 107);
            panel1.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(424, 22);
            label1.Name = "label1";
            label1.Size = new Size(472, 62);
            label1.TabIndex = 5;
            label1.Text = "Ürün Ekleme Sayfası";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 674);
            panel2.Name = "panel2";
            panel2.Size = new Size(1294, 26);
            panel2.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(39, 503);
            label3.Name = "label3";
            label3.Size = new Size(348, 20);
            label3.TabIndex = 48;
            label3.Text = "Lütfen eklemek istediğiniz ürüne ait bilgileri girin.";
            // 
            // AddStokForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(1294, 700);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(lblBarcode);
            Controls.Add(lblSFiyat);
            Controls.Add(lblBakiye);
            Controls.Add(lblAd);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(btnEkle);
            Controls.Add(dataGridView);
            Controls.Add(txtSFiyat);
            Controls.Add(txtBakiye);
            Controls.Add(txtAd);
            Controls.Add(txtBarkod);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStokForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Ekle";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.TextBox txtSFiyat;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarkodColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BakiyeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SFiyatColumn;
        private Button btnEkle;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblAd;
        private Label lblBakiye;
        private Label lblSFiyat;
        private Label lblBarcode;
        private Button button2;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
    }
}
