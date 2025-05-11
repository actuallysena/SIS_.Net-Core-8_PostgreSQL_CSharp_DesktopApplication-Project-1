using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Interfaces;
using DataLayer.Models;
using DataLayer.Interfaces;
using System.Linq;

namespace BusinessLogicLayer.Services
{
    public class LoginService : ILoginService
    {
        private readonly IRepository<Ogrenci> _ogrenciRepo;
        private readonly IRepository<Akademisyen> _akademisyenRepo;
        private readonly IRepository<Personel> _personelRepo;
        private readonly IRepository<Yonetici> _yoneticiRepo;

        public LoginService(
            IRepository<Ogrenci> ogrenciRepo,
            IRepository<Akademisyen> akademisyenRepo,
            IRepository<Personel> personelRepo,
            IRepository<Yonetici> yoneticiRepo)
        {
            _ogrenciRepo = ogrenciRepo;
            _akademisyenRepo = akademisyenRepo;
            _personelRepo = personelRepo;
            _yoneticiRepo = yoneticiRepo;
        }

        public bool OgrenciGirisi(int Ogr_GirisId, string sifre)
        {
            return _ogrenciRepo
                .Bul(o => o.OgrNo == Ogr_GirisId && o.OgrSifre == sifre)
                .Any();
        }

        public bool AkademisyenGirisi(int Aka_GirisId, string sifre) //BUNLARDA ALINAN ID İÇİN STRİNGLERİ İNT'E ÇEVİDİKTEN SONRA ATAMA YAPMAYIİ UNUTMAYALIM!
        {
            return _akademisyenRepo
                .Bul(a => a.AkademisyenId == Aka_GirisId && a.AkademisyenSifre == sifre)
                .Any();
        }

        public bool PersonelGirisi(int Per_GirisId, string sifre)
        {
            return _personelRepo
                .Bul(p => p.PersId == Per_GirisId && p.PersSifre == sifre)
                .Any();
        }

        public bool YoneticiGirisi(int Yon_GirisId, string sifre)
        {
            return _yoneticiRepo
                .Bul(y => y.YoneticiId == Yon_GirisId && y.Sifre == sifre)
                .Any();
        }
    }
}
