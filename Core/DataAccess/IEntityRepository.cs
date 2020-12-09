using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic Repository <T> where T:class,IEntity,new()
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //Güncelleme yapacağımız zaman genelde Id'ye göre yapılır.
        T Get(Expression<Func<T,bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
