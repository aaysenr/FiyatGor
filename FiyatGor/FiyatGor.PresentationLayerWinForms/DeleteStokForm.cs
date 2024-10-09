using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using FiyatGor.BusinessLayer.Abstracts;
using FiyatGor.BusinessLayer.Concrets;
using FiyatGor.BusinessLayer.DTOs;

namespace FiyatGor.PresentationLayerWinForms.Forms
{
    public partial class DeleteStokForm : Form
    {
        private readonly IStokService _stokService;

        public DeleteStokForm(IStokService stokService)
        {
            InitializeComponent();
            _stokService = stokService;
            InitializeDataGridView();
            button2.Click += Button2_Click;
        }

        private void InitializeDataGridView()
        {
            dgvDeletedItems.Columns.Clear();
            dgvDeletedItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Barkod", MinimumWidth = 6, Name = "Barkod", Width = 125 });
            dgvDeletedItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ad", MinimumWidth = 6, Name = "Ad", Width = 125 });
            dgvDeletedItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Bakiye", MinimumWidth = 6, Name = "Bakiye", Width = 125 });
            dgvDeletedItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Satış Fiyatı", MinimumWidth = 6, Name = "SFiyat", Width = 125 });
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var barcode = txtBarcode.Text.Trim();
            if (string.IsNullOrEmpty(barcode))
            {
                MessageBox.Show("Barkod numarasını giriniz.");
                return;
            }

            try
            {
                // Stok bilgilerini al.
                var itemToDelete = await _stokService.GetStokDetailsAsync(barcode);

                if (itemToDelete == null)
                {
                    MessageBox.Show("Barkod numarası ile eşleşen ürün bulunamadı.");
                    return;
                }

                // Silme işlemini yap.
                await _stokService.DeleteStokByBarcodeAsync(barcode);

                // Silme sonrası ürün bulunamazsa, kullanıcıya bilgi ver.
                MessageBox.Show("Ürün başarıyla silindi.");

                // DataGridView'e silinen ürün bilgilerini ekle.
                dgvDeletedItems.Rows.Add(
                    itemToDelete.Barkod, 
                    itemToDelete.Ad, 
                    itemToDelete.Bakiye.ToString(), 
                    itemToDelete.SFiyat.ToString() 
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Mevcut formu kapat.
            this.Close();

            // Ana sayfa formunu oluştur ve göster.
            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm == null)
            {
                // Eğer MainForm açık değilse yeni bir tane oluştur.
                mainForm = new MainForm(_stokService); 
            }
            mainForm.Show();
        }
    }
}
