namespace FiyatGor.PresentationLayerWinForms
{
    partial class UpdateStokForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStokForm));
            lblAd = new Label();
            txtAd = new TextBox();
            lblBakiye = new Label();
            txtBakiye = new TextBox();
            lblSFiyat = new Label();
            txtSFiyat = new TextBox();
            btnUpdate = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Barkod = new DataGridViewTextBoxColumn();
            Ad = new DataGridViewTextBoxColumn();
            Bakiye = new DataGridViewTextBoxColumn();
            SFiyat = new DataGridViewTextBoxColumn();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAd.Location = new Point(20, 423);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(79, 20);
            lblAd.TabIndex = 2;
            lblAd.Text = "Güncel Ad";
            // 
            // txtAd
            // 
            txtAd.ForeColor = Color.Gray;
            txtAd.Location = new Point(248, 416);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(232, 27);
            txtAd.TabIndex = 3;
            txtAd.Text = "Güncel Ad";
            txtAd.Enter += TxtAd_Enter;
            txtAd.Leave += TxtAd_Leave;
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBakiye.Location = new Point(18, 479);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(105, 20);
            lblBakiye.TabIndex = 6;
            lblBakiye.Text = "Güncel Bakiye";
            // 
            // txtBakiye
            // 
            txtBakiye.ForeColor = Color.Gray;
            txtBakiye.Location = new Point(248, 472);
            txtBakiye.Name = "txtBakiye";
            txtBakiye.Size = new Size(232, 27);
            txtBakiye.TabIndex = 7;
            txtBakiye.Text = "Güncel Bakiye";
            txtBakiye.Enter += TxtBakiye_Enter;
            txtBakiye.Leave += TxtBakiye_Leave;
            // 
            // lblSFiyat
            // 
            lblSFiyat.AutoSize = true;
            lblSFiyat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSFiyat.Location = new Point(18, 543);
            lblSFiyat.Name = "lblSFiyat";
            lblSFiyat.Size = new Size(132, 20);
            lblSFiyat.TabIndex = 8;
            lblSFiyat.Text = "Güncel Satış Fiyatı";
            // 
            // txtSFiyat
            // 
            txtSFiyat.ForeColor = Color.Gray;
            txtSFiyat.Location = new Point(248, 536);
            txtSFiyat.Name = "txtSFiyat";
            txtSFiyat.Size = new Size(232, 27);
            txtSFiyat.TabIndex = 9;
            txtSFiyat.Text = "Güncel Satış Fiyatı";
            txtSFiyat.Enter += TxtSFiyat_Enter;
            txtSFiyat.Leave += TxtSFiyat_Leave;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.FlatAppearance.BorderColor = Color.Teal;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(368, 589);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 35);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 104);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(396, 21);
            label1.Name = "label1";
            label1.Size = new Size(571, 62);
            label1.TabIndex = 4;
            label1.Text = "Ürün Güncelleme Sayfası";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 757);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 22);
            panel2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 331);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(20, 155);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 15;
            label2.Text = "Barkod Numarası";
            label2.Click += label2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(248, 148);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(232, 27);
            textBox4.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(368, 210);
            button1.Name = "button1";
            button1.Size = new Size(112, 36);
            button1.TabIndex = 18;
            button1.Text = "Ürünü Bul";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Teal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Barkod, Ad, Bakiye, SFiyat });
            dataGridView1.Location = new Point(565, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(661, 466);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Barkod
            // 
            Barkod.HeaderText = "Barkod";
            Barkod.MinimumWidth = 6;
            Barkod.Name = "Barkod";
            Barkod.Width = 150;
            // 
            // Ad
            // 
            Ad.HeaderText = "Ad";
            Ad.MinimumWidth = 6;
            Ad.Name = "Ad";
            Ad.Width = 200;
            // 
            // Bakiye
            // 
            Bakiye.HeaderText = "Bakiye";
            Bakiye.MinimumWidth = 6;
            Bakiye.Name = "Bakiye";
            Bakiye.Width = 125;
            // 
            // SFiyat
            // 
            SFiyat.HeaderText = "Satış Fiyatı";
            SFiyat.MinimumWidth = 6;
            SFiyat.Name = "SFiyat";
            SFiyat.Width = 125;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatAppearance.BorderColor = Color.Teal;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(343, 665);
            button2.Name = "button2";
            button2.Size = new Size(139, 38);
            button2.TabIndex = 22;
            button2.Text = "Ana Sayfaya Dön";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(20, 273);
            label3.Name = "label3";
            label3.Size = new Size(455, 20);
            label3.TabIndex = 37;
            label3.Text = "Lütfen güncellemek istediğiniz ürüne ait barkod numarasını girin.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(20, 633);
            label4.Name = "label4";
            label4.Size = new Size(312, 20);
            label4.TabIndex = 38;
            label4.Text = "Lütfen güncellemek istediğiniz bilgileri girin.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(127, 337);
            label5.Name = "label5";
            label5.Size = new Size(181, 38);
            label5.TabIndex = 39;
            label5.Text = "Ürün Bilgileri";
            // 
            // UpdateStokForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 779);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnUpdate);
            Controls.Add(txtSFiyat);
            Controls.Add(lblSFiyat);
            Controls.Add(txtBakiye);
            Controls.Add(lblBakiye);
            Controls.Add(txtAd);
            Controls.Add(lblAd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateStokForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Güncelle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label lblSFiyat;
        private System.Windows.Forms.TextBox txtSFiyat;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bakiye;
        private System.Windows.Forms.DataGridViewTextBoxColumn SFiyat;
        private Button button2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
