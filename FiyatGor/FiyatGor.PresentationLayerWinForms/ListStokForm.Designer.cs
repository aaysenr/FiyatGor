namespace FiyatGor.PresentationLayerWinForms.Forms
{
    partial class ListStokForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewStoks;
        private Button buttonBackToMain;

        private void InitializeComponent()
        {
            dataGridViewStoks = new DataGridView();
            buttonBackToMain = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStoks).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewStoks
            // 
            dataGridViewStoks.BackgroundColor = Color.Teal;
            dataGridViewStoks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStoks.Location = new Point(149, 122);
            dataGridViewStoks.Name = "dataGridViewStoks";
            dataGridViewStoks.RowHeadersWidth = 51;
            dataGridViewStoks.Size = new Size(941, 481);
            dataGridViewStoks.TabIndex = 0;
            // 
            // buttonBackToMain
            // 
            buttonBackToMain.BackColor = Color.Teal;
            buttonBackToMain.FlatAppearance.BorderColor = Color.Teal;
            buttonBackToMain.FlatStyle = FlatStyle.Flat;
            buttonBackToMain.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonBackToMain.ForeColor = Color.White;
            buttonBackToMain.Location = new Point(951, 639);
            buttonBackToMain.Name = "buttonBackToMain";
            buttonBackToMain.Size = new Size(139, 38);
            buttonBackToMain.TabIndex = 1;
            buttonBackToMain.Text = "Ana Sayfaya Dön";
            buttonBackToMain.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 758);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 21);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 99);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(396, 18);
            label1.Name = "label1";
            label1.Size = new Size(416, 62);
            label1.TabIndex = 4;
            label1.Text = "Ürün Liste Sayfası";
            // 
            // ListStokForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 779);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(buttonBackToMain);
            Controls.Add(dataGridViewStoks);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListStokForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Listesi";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStoks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panel2;
        private Panel panel1;
        private Label label1;
    }
}
