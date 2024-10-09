namespace FiyatGor.PresentationLayerWinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAddStok;
        private Button btnDeleteStok;
        private Button btnGetStokDetails;
        private Button btnUpdateStok;
        private Button btnListStok;
        private Button btnExit;
        private Panel panel1;

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
            btnAddStok = new Button();
            btnDeleteStok = new Button();
            btnGetStokDetails = new Button();
            btnUpdateStok = new Button();
            btnListStok = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAddStok
            // 
            btnAddStok.BackColor = Color.White;
            btnAddStok.FlatAppearance.BorderColor = Color.Teal;
            btnAddStok.FlatStyle = FlatStyle.Flat;
            btnAddStok.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnAddStok.Location = new Point(127, 220);
            btnAddStok.Name = "btnAddStok";
            btnAddStok.Size = new Size(150, 50);
            btnAddStok.TabIndex = 1;
            btnAddStok.Text = "Ürün Ekle";
            btnAddStok.UseVisualStyleBackColor = false;
            btnAddStok.Click += BtnAddStok_Click;
            // 
            // btnDeleteStok
            // 
            btnDeleteStok.BackColor = Color.White;
            btnDeleteStok.FlatAppearance.BorderColor = Color.Teal;
            btnDeleteStok.FlatStyle = FlatStyle.Flat;
            btnDeleteStok.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnDeleteStok.Location = new Point(405, 220);
            btnDeleteStok.Name = "btnDeleteStok";
            btnDeleteStok.Size = new Size(150, 50);
            btnDeleteStok.TabIndex = 2;
            btnDeleteStok.Text = "Ürün Sil";
            btnDeleteStok.UseVisualStyleBackColor = false;
            btnDeleteStok.Click += BtnDeleteStok_Click;
            // 
            // btnGetStokDetails
            // 
            btnGetStokDetails.BackColor = Color.White;
            btnGetStokDetails.FlatAppearance.BorderColor = Color.Teal;
            btnGetStokDetails.FlatStyle = FlatStyle.Flat;
            btnGetStokDetails.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnGetStokDetails.ForeColor = SystemColors.ControlText;
            btnGetStokDetails.Location = new Point(405, 137);
            btnGetStokDetails.Name = "btnGetStokDetails";
            btnGetStokDetails.Size = new Size(150, 53);
            btnGetStokDetails.TabIndex = 3;
            btnGetStokDetails.Text = "Ürün Getir";
            btnGetStokDetails.UseVisualStyleBackColor = false;
            btnGetStokDetails.Click += BtnGetStokDetails_Click;
            // 
            // btnUpdateStok
            // 
            btnUpdateStok.BackColor = Color.White;
            btnUpdateStok.FlatAppearance.BorderColor = Color.Teal;
            btnUpdateStok.FlatStyle = FlatStyle.Flat;
            btnUpdateStok.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnUpdateStok.Location = new Point(127, 306);
            btnUpdateStok.Name = "btnUpdateStok";
            btnUpdateStok.Size = new Size(150, 52);
            btnUpdateStok.TabIndex = 4;
            btnUpdateStok.Text = "Ürün Güncelle";
            btnUpdateStok.UseVisualStyleBackColor = false;
            btnUpdateStok.Click += BtnUpdateStok_Click;
            // 
            // btnListStok
            // 
            btnListStok.BackColor = Color.White;
            btnListStok.FlatAppearance.BorderColor = Color.Teal;
            btnListStok.FlatStyle = FlatStyle.Flat;
            btnListStok.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnListStok.Location = new Point(405, 306);
            btnListStok.Name = "btnListStok";
            btnListStok.Size = new Size(150, 52);
            btnListStok.TabIndex = 5;
            btnListStok.Text = "Ürün Listele";
            btnListStok.UseVisualStyleBackColor = false;
            btnListStok.Click += BtnListStok_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderColor = Color.DarkRed;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(558, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(65, 29);
            btnExit.TabIndex = 9;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += BtnExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(77, 476);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.Location = new Point(127, 137);
            button1.Name = "button1";
            button1.Size = new Size(150, 53);
            button1.TabIndex = 10;
            button1.Text = "Barkod Okuma (Cihaz)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(168, 61);
            label1.Name = "label1";
            label1.Size = new Size(423, 54);
            label1.TabIndex = 12;
            label1.Text = "FiyatGör Uygulaması";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(232, 398);
            label3.Name = "label3";
            label3.Size = new Size(268, 20);
            label3.TabIndex = 37;
            label3.Text = "Lütfen yapmak istediğiniz işlemi seçin.";
            // 
            // MainForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(635, 476);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            Controls.Add(btnAddStok);
            Controls.Add(btnDeleteStok);
            Controls.Add(btnGetStokDetails);
            Controls.Add(btnUpdateStok);
            Controls.Add(btnListStok);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FiyatGör ";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Label label1;
        private Label label3;
    }
}
