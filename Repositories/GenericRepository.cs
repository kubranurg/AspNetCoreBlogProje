using DataAcessLayer.Abstract;
using DataAcessLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAcessLayer.Repositories
{
    public class GenericRepository<T> : IGeneric<T> where T : class
    {
        public void Delete(T t)
        {
            using var db = new Context();
            db.Remove(t);
            db.SaveChanges();
        }

        public T GetById(int id)
        {
            using var db = new Context();
            return db.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var db = new Context();
            return db.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var db = new Context();
            db.Add(t);
            db.SaveChanges();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            using var db = new Context();
            return db.Set<T>().Where(filter).ToList();
        }

        public void Update(T t)
        {
            using var db = new Context();
            db.Update(t);
            db.SaveChanges();
        }
    }

    
}
