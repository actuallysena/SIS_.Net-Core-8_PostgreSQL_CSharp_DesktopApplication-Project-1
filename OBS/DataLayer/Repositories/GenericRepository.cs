using DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataLayer; // ObsDbContexti tanimlamistik


namespace DataLayer.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly ObsDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ObsDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IEnumerable<T> HepsiniGetir()
        {
            return _dbSet.ToList();
        }

        public T GetirId(int id)
        {
            var alinan = _dbSet.Find(id);
            if (alinan == null)
                throw new Exception("Kayıt bulunamadı.");
            return alinan;
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
