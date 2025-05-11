using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface ILoginService
    {
        bool OgrenciGirisi(int Ogr_GirisId, string sifre);
        bool AkademisyenGirisi(int Aka_GirisId, string sifre);
        bool PersonelGirisi(int Per_GirisId, string sifre);
        bool YoneticiGirisi(int Yon_GirisId, string sifre);
    }
}
