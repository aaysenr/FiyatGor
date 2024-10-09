using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FiyatGor.BusinessLayer.Abstracts;
using FiyatGor.BusinessLayer.DTOs;

namespace FiyatGor.PresentationLayerWinForms
{
    public partial class AddStokForm : Form
    {
        private readonly IStokService _stokService;

        public AddStokForm(IStokService stokService)
        {
            InitializeComponent();
            _stokService = stokService;
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var barkod = txtBarkod.Text;
                var ad = txtAd.Text;
                if (string.IsNullOrWhiteSpace(barkod))
                {
                    MessageBox.Show("Barkod numarasını giriniz.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(ad))
                {
                    MessageBox.Show("Ürün adı boş olamaz.");
                    return;
                }
                if (!double.TryParse(txtBakiye.Text, out var bakiye))
                {
                    MessageBox.Show("Bakiye geçerli bir sayı olmalıdır.");
                    return;
                }
                if (!double.TryParse(txtSFiyat.Text, out var sfiyat))
                {
                    MessageBox.Show("Satış Fiyatı geçerli bir sayı olmalıdır.");
                    return;
                }

                await _stokService.AddNewStokAsync(barkod, ad, bakiye, sfiyat);

                // yeni bir StokDetailsDto oluştur.
                var newStok = new StokDetailsDto
                {
                    Barkod = barkod,
                    Ad = ad,
                    Bakiye = bakiye,
                    SFiyat = sfiyat
                };

                // DataGridView ekle.
                AddToDataGridView(newStok);


                MessageBox.Show("Stok başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata bulundu: {ex.Message}");
            }
        }


        private void AddToDataGridView(StokDetailsDto stok)
        {
            // Datagridview'ın en üstüne yeni bir satır ekle.
            dataGridView.Rows.Insert(0, stok.Barkod, stok.Ad, stok.Bakiye, stok.SFiyat);

            // Yeni satırın görünür ve seçili olması.
            if (dataGridView.Rows.Count > 0)
            {
                int newRowIndex = 0; // Yeni eklenen satırın indeksini belirle.
                dataGridView.FirstDisplayedScrollingRowIndex = newRowIndex;
                dataGridView.Rows[newRowIndex].Selected = true;
                dataGridView.CurrentCell = dataGridView.Rows[newRowIndex].Cells[0];
            }
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            // Geçerli formu kapat.
            this.Close();

            // Mevcut MainForm'u aç.
            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm == null)
            {
                // Mevcut bir MainForm yoksa, yeni bir tane oluştur.
                mainForm = new MainForm(_stokService);
            }

            // MainForm'u göster.
            mainForm.Show();

            // MainForm sayfasını öne getir.
            mainForm.BringToFront();
        }

    }
}
