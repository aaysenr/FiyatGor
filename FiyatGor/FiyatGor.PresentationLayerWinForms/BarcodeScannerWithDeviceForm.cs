using FiyatGor.BusinessLayer.Abstracts;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiyatGor.PresentationLayerWinForms
{
    public partial class BarcodeScannerWithDeviceForm : Form
    {
        private readonly IStokService _stokService;
        private string _currentBarcode = string.Empty;

        public BarcodeScannerWithDeviceForm(IStokService stokService)
        {
            InitializeComponent();
            _stokService = stokService;
            this.KeyPreview = true; // Formun key events'lerini almak için.
            this.KeyPress += Form_KeyPress; // KeyPress olayını işleyiciye bağlama.
            this.AcceptButton = null; // Varsayılan butonu kaldırma.
        }

        private void Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Space tuşunu işleme almama.
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // Space tuşunu işleme alma.
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Varsayılan işlemi durdur.
                ProcessBarcode(_currentBarcode.Trim()); // Barkodu işle.
                _currentBarcode = string.Empty; // Barkod verisini sıfırla.
            }
            else if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '-') // Sadece harf, rakam ve '-' karakterlerine izin ver.
            {
                _currentBarcode += e.KeyChar;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Space tuşu işlemini tamamen engelle.
            if (keyData == Keys.Space)
            {
                return true; // Space tuşunun işlenmesini engelle.
            }

            if (keyData == Keys.Enter)
            {
                // Enter tuşuna basıldığında yapılacak işlemi çağır.
                Task.Run(() => ProcessBarcode(_currentBarcode.Trim()));
                _currentBarcode = string.Empty; // Barkod verisini sıfırla.
                return true; // Tuş işleminin diğer kısımları tarafından işlenmesini engelle.
            }

            // Diğer tuşlara geçiş yap.
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private async Task ProcessBarcode(string barcode)
        {
            if (string.IsNullOrWhiteSpace(barcode)) return;

            try
            {
                // Barkod ile ürün bilgilerini al.
                var stokDetails = await _stokService.GetStokDetailsAsync(barcode);

                if (stokDetails != null)
                {
                    // Ürün bilgilerini etiketlere yazdır.
                    lblBarkod.Invoke((Action)(() => lblBarkod.Text = $"Barkod Numarası: {stokDetails.Barkod}"));
                    lblAd.Invoke((Action)(() => lblAd.Text = $"Ad: {stokDetails.Ad}"));
                    lblSFiyat.Invoke((Action)(() => lblSFiyat.Text = $"Satış Fiyatı: {stokDetails.SFiyat:C}"));
                    lblBakiye.Invoke((Action)(() => lblBakiye.Text = $"Bakiye: {stokDetails.Bakiye}"));
                }
                else
                {
                    lblBarkod.Invoke((Action)(() => lblBarkod.Text = "Barkod numarası bulunamadı."));
                    lblAd.Invoke((Action)(() => lblAd.Text = ""));
                    lblSFiyat.Invoke((Action)(() => lblSFiyat.Text = ""));
                    lblBakiye.Invoke((Action)(() => lblBakiye.Text = ""));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm == null)
            {
                mainForm = new MainForm(_stokService); 
                mainForm.Show();
            }
            else
            {
                mainForm.BringToFront(); // Form mevcutsa onu ön plana getir.
            }

            this.Close(); // Mevcut formu kapat.
        }


    }
}
