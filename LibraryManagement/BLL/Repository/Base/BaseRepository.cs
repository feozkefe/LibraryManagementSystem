using Library.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace BLL.Repository.Base
{
    public class BaseRepository<T> where T : class
    {
        private LibraryManagementEntities db;
        protected DbSet<T> table;
        public BaseRepository()
        {
            db = new LibraryManagementEntities();
            table = db.Set<T>();
        }
        public int Save()
        {
            return db.SaveChanges();
        }
        public virtual void insert(T entity)
        {
            table.Add(entity);
            Save();
        }
        public bool Any(Expression<Func<T, bool>> perdicate)
        {
            return table.Any(perdicate);
        }
        public List<T> GetAll()
        {
            return table.ToList();
        }
        public T Find(int id)
        {
            return table.Find(id);
        }
        public List<T> GetByCondition(Expression<Func<T, bool>> perdicate)
        {
            return table.Where(perdicate).ToList();
        }
        public void delete(int id)
        {
            T entity = table.Find(id);
            table.Remove(entity);
            Save();
        }
    }
}
