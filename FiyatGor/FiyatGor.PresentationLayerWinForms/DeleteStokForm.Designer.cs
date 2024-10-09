namespace FiyatGor.PresentationLayerWinForms.Forms
{
    partial class DeleteStokForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtBarcode;
        private Button btnDelete;
        private Label lblBarcode;
        private DataGridView dgvDeletedItems;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteStokForm));
            txtBarcode = new TextBox();
            btnDelete = new Button();
            lblBarcode = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            dgvDeletedItems = new DataGridView();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeletedItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(12, 273);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(411, 27);
            txtBarcode.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Teal;
            btnDelete.FlatAppearance.BorderColor = Color.Teal;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(347, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(76, 32);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBarcode.Location = new Point(12, 213);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(128, 20);
            lblBarcode.TabIndex = 2;
            lblBarcode.Text = "Barkod Numarası";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 99);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(425, 20);
            label1.Name = "label1";
            label1.Size = new Size(435, 62);
            label1.TabIndex = 4;
            label1.Text = "Ürün Silme Sayfası";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 761);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 18);
            panel2.TabIndex = 4;
            // 
            // dgvDeletedItems
            // 
            dgvDeletedItems.BackgroundColor = Color.Teal;
            dgvDeletedItems.BorderStyle = BorderStyle.None;
            dgvDeletedItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeletedItems.Location = new Point(569, 132);
            dgvDeletedItems.Name = "dgvDeletedItems";
            dgvDeletedItems.RowHeadersWidth = 51;
            dgvDeletedItems.Size = new Size(631, 464);
            dgvDeletedItems.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 123);
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
            button2.Location = new Point(284, 484);
            button2.Name = "button2";
            button2.Size = new Size(139, 38);
            button2.TabIndex = 23;
            button2.Text = "Ana Sayfaya Dön";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 426);
            label3.Name = "label3";
            label3.Size = new Size(411, 20);
            label3.TabIndex = 37;
            label3.Text = "Lütfen silmek istediğiniz ürüne ait barkod numarasını girin.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(92, 130);
            label2.Name = "label2";
            label2.Size = new Size(181, 38);
            label2.TabIndex = 38;
            label2.Text = "Ürün Bilgileri";
            // 
            // DeleteStokForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 779);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(dgvDeletedItems);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblBarcode);
            Controls.Add(btnDelete);
            Controls.Add(txtBarcode);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteStokForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "s";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeletedItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button2;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
