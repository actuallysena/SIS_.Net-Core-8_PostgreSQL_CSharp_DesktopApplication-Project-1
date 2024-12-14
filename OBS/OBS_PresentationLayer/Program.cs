using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using OBS_DataAccessLayer.Models;  // DbContext
using OBS_DataAccessLayer.Repositories;  // Repository
using OBS_DataAccessLayer.Interfaces;  // IRepository
using Microsoft.EntityFrameworkCore;
using OBS_DataAccessLayer;
using Microsoft.Extensions.Configuration;


namespace OBS_PresentationLayer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // appsettings.json'u okuyacak Configuration Builder
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)  // Çalýþan dizine göre ayar
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();


            // Ortama göre baðlantý dizesini seç
            string? environment = configuration["Environment"];//null döndürme ihtimali olduðundan string?
            string? connectionString = environment == "Remote"
                ? configuration.GetConnectionString("RemoteDb")
                : configuration.GetConnectionString("LocalDb");

            // DI Konteyneri
            var serviceProvider = new ServiceCollection()
                .AddDbContext<ObsDbContext>(options =>
                    options.UseNpgsql(connectionString), ServiceLifetime.Transient) // Transient DbContext
                .AddTransient<Form1>() // Transient Form1
                .BuildServiceProvider();

            // Uygulamayý baþlat
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }
    }
}
