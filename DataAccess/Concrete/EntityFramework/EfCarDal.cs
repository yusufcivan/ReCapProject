using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        //IDisposable pattern implementation of c#
        public void Add(Car entity)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                //Git verikaynağından gönderdiğim Car'dan bir nesnesyi eslestir.Ekleme olacağı için eşleme olmayacak ekleyecek
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                //Git verikaynağından gönderdiğim product'tan bir nesnesyi eslestir
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                //filtre null mı? evet ise tümünü getir : null değilse filtreleyip ver
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();

            }
        }

        public void Update(Car entity)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
