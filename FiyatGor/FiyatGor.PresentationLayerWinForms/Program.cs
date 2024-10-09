using FiyatGor.BusinessLayer.Abstracts;
using FiyatGor.BusinessLayer.Concrets;
using FiyatGor.DataAccessLayer.Abstracts;
using FiyatGor.DataAccessLayer.Concrets;
using FiyatGor.DataAccessLayer.Context;
using FiyatGor.PresentationLayerWinForms.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

namespace FiyatGor.PresentationLayerWinForms
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            // Visual stil ve metin ayarlarýný etkinleþtirme.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Baðýmlýlýklarý yapýlandýrma.

            var host = CreateHostBuilder().Build();

            // Ana formu baþlatma.

            Application.Run(host.Services.GetRequiredService<MainForm>());
        }

        // Host builder'ý oluþturma.
        public static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    // appsettings.json dosyasýný yükleme.

                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    // Baðlantý dizesini konfigürasyon dosyasýndan okuma.

                    var connectionString = context.Configuration.GetConnectionString("Fiyatgordb");

                    // DbContext'i yapýlandýrma.

                    services.AddDbContext<FiyatgordbContext>(options =>
                        options.UseMySql(connectionString, Microsoft.EntityFrameworkCore.ServerVersion.Parse("9.0.1-mysql")));

                    // Ýþ servislerini ve diðer baðýmlýlýklarý ekleme.

                    services.AddTransient<IStokService, StokService>();
                    services.AddTransient<IStokRepository, StokRepository>();

                    // Ana formu veya pencereyi ekleme.

                    services.AddTransient<MainForm>();
                    services.AddTransient<AddStokForm>();
                    services.AddTransient<DeleteStokForm>();
                    services.AddTransient<UpdateStokForm>();
                    services.AddTransient<GetStokForm>();
                    services.AddTransient<ListStokForm>();
                    services.AddTransient<BarcodeScannerWithDeviceForm>();
                

                });
    }
}
