using Microsoft.EntityFrameworkCore;
using OBS_DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OBS_DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IEnumerable<T> HepsiniGetir()
        {
            return _dbSet.ToList();
        }

        public T GetirId(int id)
        {
            // null referans hatası vermemesi için kontrol ettik
            var entity = _context.Set<T>().Find(id); // Find ile varlığı alıyoruz.
            if (entity == null)
            {
                // Varlık bulunamadıysa, uygun bir işlem yapılabilir
                throw new KeyNotFoundException("Varlık bulunamadı"); // Örneğin bir hata mesajı verebilir
            }
            return entity;
        }

        public IEnumerable<T> Bul(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public void Ekle(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void CokluEkle(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
            _context.SaveChanges();
        }

        public void Guncelle(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Kaldir(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public void CokluKaldir(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
            _context.SaveChanges();
        }
    }
}
