using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiyatGor.BusinessLayer.Abstracts;
using FiyatGor.BusinessLayer.DTOs;


namespace FiyatGor.PresentationLayerWinForms
{
    public partial class UpdateStokForm : Form
    {
        private readonly IStokService _stokService;

        public UpdateStokForm(IStokService stokService)
        {
            InitializeComponent();
            _stokService = stokService;
            this.Shown += UpdateStokForm_Shown;
        }

        private void UpdateStokForm_Shown(object sender, EventArgs e)
        {
            textBox4.Focus();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string barcode = textBox4.Text.Trim();

            if (string.IsNullOrEmpty(barcode))
            {
                MessageBox.Show("Barkod numarasını giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var stokDetails = await _stokService.GetStokDetailsAsync(barcode);

                if (stokDetails != null)
                {
                    
                    txtAd.Text = stokDetails.Ad;
                    txtBakiye.Text = stokDetails.Bakiye.ToString();
                    txtSFiyat.Text = stokDetails.SFiyat.ToString();

                    txtAd.ForeColor = Color.Black;
                    txtBakiye.ForeColor = Color.Black;
                    txtSFiyat.ForeColor = Color.Black;

                    UpdateDataGridView(barcode, stokDetails.Ad, stokDetails.Bakiye, stokDetails.SFiyat);
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string barcode = textBox4.Text.Trim();
            string ad = txtAd.Text.Trim();
            double bakiye;
            double sfiyat;

            if (string.IsNullOrEmpty(barcode))
            {
                MessageBox.Show("Barkod numarasını giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (double.TryParse(txtBakiye.Text, out bakiye) && double.TryParse(txtSFiyat.Text, out sfiyat))
                {
                    await _stokService.UpdateStokDetailsAsync(barcode, ad, bakiye, sfiyat);
                    MessageBox.Show("Ürün başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDataGridView(barcode, ad, bakiye, sfiyat);
                }
                else
                {
                    MessageBox.Show("Bakiye ve satış fiyatı geçerli sayılar olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataGridViewRow _lastUpdatedRow;

        private void UpdateDataGridView(string barcode, string ad, double bakiye, double sfiyat)
        {
            // Barkodun DataGridView'da zaten var olup olmadığını kontrol et.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == barcode)
                {
                    // Mevcut satırı güncelle.
                    row.Cells[1].Value = ad;
                    row.Cells[2].Value = bakiye;
                    row.Cells[3].Value = sfiyat;

                    // Güncelleştirilmiş satırı en üste taşı.
                    dataGridView1.Rows.Remove(row);
                    dataGridView1.Rows.Insert(0, row);

                    // _lastUpdatedRow güncelleştirilmiş satıra ayarla.
                    _lastUpdatedRow = row;

                    // Geçerli hücreyi güncelleştirilmiş satırın ilk hücresi haline getir.
                    dataGridView1.CurrentCell = row.Cells[0];

                    return;
                }
            }

            // Barkod yoksa, en üste yeni bir satır ekle.
            var newRow = new DataGridViewRow();
            newRow.CreateCells(dataGridView1, barcode, ad, bakiye, sfiyat);
            dataGridView1.Rows.Insert(0, newRow);

            // _lastUpdatedRow yeni satır olarak ayarla.
            _lastUpdatedRow = newRow;

            // Geçerli hücreyi yeni satırın ilk hücresine dönüştür.
            dataGridView1.CurrentCell = newRow.Cells[0];
        }

        // Son güncellenen satıra odaklanmayı sürdürmek için fare hareketlerini işleme yöntemi.
        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_lastUpdatedRow != null)
            {
                //En son güncellenen satır görünür durumda mı? Kontrol et.
                if (_lastUpdatedRow.Index >= 0 && _lastUpdatedRow.Index < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = _lastUpdatedRow.Cells[0];
                }
            }
        }



        private void TxtAd_Enter(object sender, EventArgs e)
        {
            if (txtAd.ForeColor == Color.Gray)
            {
                txtAd.Text = "";
                txtAd.ForeColor = Color.Black;
            }
        }

        private void TxtAd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text))
            {
                txtAd.Text = "Güncel Ad";
                txtAd.ForeColor = Color.Gray;
            }
        }

        private void TxtBakiye_Enter(object sender, EventArgs e)
        {
            if (txtBakiye.ForeColor == Color.Gray)
            {
                txtBakiye.Text = "";
                txtBakiye.ForeColor = Color.Black;
            }
        }

        private void TxtBakiye_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBakiye.Text))
            {
                txtBakiye.Text = "Güncel Bakiye";
                txtBakiye.ForeColor = Color.Gray;
            }
        }

        private void TxtSFiyat_Enter(object sender, EventArgs e)
        {
            if (txtSFiyat.ForeColor == Color.Gray)
            {
                txtSFiyat.Text = "";
                txtSFiyat.ForeColor = Color.Black;
            }
        }

        private void TxtSFiyat_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSFiyat.Text))
            {
                txtSFiyat.Text = "Güncel Satış Fiyatı";
                txtSFiyat.ForeColor = Color.Gray;
            }
        }

        
        private void label2_Click(object sender, EventArgs e) { }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        

        private void button2_Click(object sender, EventArgs e)
        {
            // Ana formu aç ve bu formu kapat.
            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.Show();
            }
            this.Close();
        }
    }
}
