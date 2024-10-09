using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiyatGor.BusinessLayer.Abstracts;
using FiyatGor.BusinessLayer.DTOs;
using Microsoft.Extensions.DependencyInjection;
using FiyatGor.PresentationLayerWinForms.Forms;

namespace FiyatGor.PresentationLayerWinForms
{
    public partial class MainForm : Form
    {
        private readonly IStokService _stokService;

        public MainForm(IStokService stokService)
        {
            InitializeComponent();
            _stokService = stokService;
            Load += MainForm_Load;
            Shown += MainForm_Shown;
        }

        private void BtnAddStok_Click(object sender, EventArgs e)
        {
            OpenForm<AddStokForm>();
        }

        private void BtnDeleteStok_Click(object sender, EventArgs e)
        {
            OpenForm<DeleteStokForm>();
        }

        private void BtnGetStokDetails_Click(object sender, EventArgs e)
        {
            OpenForm<GetStokForm>();
        }

        private void BtnUpdateStok_Click(object sender, EventArgs e)
        {
            OpenForm<UpdateStokForm>();
        }

        private void BtnListStok_Click(object sender, EventArgs e)
        {
            OpenForm<ListStokForm>();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenForm<BarcodeScannerWithDeviceForm>();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void OpenForm<T>() where T : Form
        {
            try
            {
                var form = (T)Activator.CreateInstance(typeof(T), _stokService);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Form açılırken bir hata oluştu: {ex.Message}");
            }
        }
    }
}
