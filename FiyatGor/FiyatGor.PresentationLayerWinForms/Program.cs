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
            // Visual stil ve metin ayarlar�n� etkinle�tirme.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ba��ml�l�klar� yap�land�rma.

            var host = CreateHostBuilder().Build();

            // Ana formu ba�latma.

            Application.Run(host.Services.GetRequiredService<MainForm>());
        }

        // Host builder'� olu�turma.
        public static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    // appsettings.json dosyas�n� y�kleme.

                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    // Ba�lant� dizesini konfig�rasyon dosyas�ndan okuma.

                    var connectionString = context.Configuration.GetConnectionString("Fiyatgordb");

                    // DbContext'i yap�land�rma.

                    services.AddDbContext<FiyatgordbContext>(options =>
                        options.UseMySql(connectionString, Microsoft.EntityFrameworkCore.ServerVersion.Parse("9.0.1-mysql")));

                    // �� servislerini ve di�er ba��ml�l�klar� ekleme.

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
