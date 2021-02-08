using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //filter null demek filtre vermeyebilirsin demek
        T Get(Expression<Func<T, bool>> filter); // filtre vermek zorunlu

        //List<Car> GetAllByBrandId(int BrandId);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
