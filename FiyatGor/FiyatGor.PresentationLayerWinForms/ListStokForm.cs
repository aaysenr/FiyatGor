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


namespace FiyatGor.PresentationLayerWinForms.Forms
{
    public partial class ListStokForm : Form
    {
        private readonly IStokService _stokService;

        public ListStokForm(IStokService stokService)
        {
            InitializeComponent();
            _stokService = stokService;
            LoadStoksAsync();
            buttonBackToMain.Click += ButtonBackToMain_Click; // Ana sayfaya dön butonunu bağlama.
        }

        private async void LoadStoksAsync()
        {
            try
            {
                var stoks = await _stokService.GetAllStoksAsync();

                // Barkod numaralarını sayısal olarak sıralamak için.
                var sortedStoks = stoks
                    .Select(stok => new
                    {
                        Stok = stok,
                        BarkodAsInt = int.TryParse(stok.Barkod, out int barkodInt) ? barkodInt : int.MaxValue // Bozuk veya geçersiz numaralar en sona yerleştirilir.
                    })
                    .OrderBy(x => x.BarkodAsInt)
                    .Select(x => x.Stok)
                    .ToList();

                dataGridViewStoks.DataSource = sortedStoks;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonBackToMain_Click(object sender, EventArgs e)
        {
            // Mevcut formu kapat.
            this.Close();

            // Ana sayfa formunu oluştur ve göster.
            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm == null)
            {
                // Eğer MainForm açık değilse yeni bir tane oluşturulur.
                mainForm = new MainForm(_stokService); 
            }
            mainForm.Show();
        }

       
    }
}
