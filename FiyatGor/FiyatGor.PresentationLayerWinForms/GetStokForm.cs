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
    public partial class GetStokForm : Form
    {
        private readonly IStokService _stokService;

        public GetStokForm(IStokService stokService)
        {
            InitializeComponent();
            _stokService = stokService;
        }

        private async void btnGetDetails_Click(object sender, EventArgs e)
        {
            var barcode = txtBarcode.Text.Trim();
            if (string.IsNullOrWhiteSpace(barcode))
            {
                MessageBox.Show("Barkod numarasını giriniz.");
                return;
            }

            try
            {
                var stokDto = await _stokService.GetStokDetailsAsync(barcode);
                if (stokDto == null)
                {
                    MessageBox.Show("Barkod numarası ile eşleşen ürün bulunamadı.");
                }
                else
                {
                    // Bilgileri forma aktar
                    txtAd.Text = stokDto.Ad;
                    txtBakiye.Text = stokDto.Bakiye.ToString("F2");
                    txtSFiyat.Text = stokDto.SFiyat.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void GetStokForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler...
        }

        private void lblAd_Click(object sender, EventArgs e)
        {
            // lblAd tıklama olayı.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ana formu oluştur ve göster.
            var mainForm = new MainForm(_stokService); // MainForm'u oluştur.
            mainForm.Show(); // Ana formu göster.

            // Şu anki formu kapat.
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
