using System;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using Infrastructure;
using BusinessLogicLayer.Services;
using BusinessLogicLayer.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace PresentationLayer
{
    internal static class Program
    {
        public static IServiceProvider serviceProvider = null!; //.NET 6 ÜZERİ SÜRÜMLERDE REFERANS TİPLER NULL OLABİLDİĞİNDEN OLAMAYANI BEİRTMEK GEREKLİYORMUŞ.

        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            // Connection string: (CONFİG DOSYASI YAPABİLİRİZ)
            string connectionString = "Host=localhost;Database=obs_db;Username=postgres;Password=123";

            //DI servislerini dahil ediyoruz Infrastructure üzerinden..
            services.AddApplicationServices(connectionString);
            // ServiceProvider nesnesi global oldu
            serviceProvider = services.BuildServiceProvider();

            // WinForms başlangıcı
            ApplicationConfiguration.Initialize();
            Application.Run(new GirisForm());
        }
    }
}
