using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAcessLayer.Abstract
{
     public interface IGeneric<T> where T : class 
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetListAll();
        T GetById(int id); 
        List<T> GetListAll(Expression<Func<T, bool>> filter);

    }
}
