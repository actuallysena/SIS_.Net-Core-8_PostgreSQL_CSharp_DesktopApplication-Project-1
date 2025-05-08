using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> HepsiniGetir(); // Tüm veriyi getir
        T GetirId(int id); // Belirli bir ID'ye göre veri getir
        IEnumerable<T> Bul(Expression<Func<T, bool>> predicate); // Koşula göre veri bul
        void Ekle(T entity); // Yeni bir kayıt ekle
        void CokluEkle(IEnumerable<T> entities); // Birden fazla kayıt ekle
        void Guncelle(T entity); // Mevcut bir kaydı güncelle
        void Kaldir(T entity); // Bir kaydı sil
        void CokluKaldir(IEnumerable<T> entities); // Birden fazla kaydı sil
    }
}