using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        //GetById, GetAll, Add, Update, Delete 
        //Id, BrandId, ColorId, ModelYear, DailyPrice, Description
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int BrandId);

        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);


    }
}
