﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId =1, BrandId=1, ColorId=1, DailyPrice = 20000, Description="Şahin", ModelYear= 1960 },
                new Car {CarId =2, BrandId=1, ColorId=2, DailyPrice = 30000, Description="idare eder", ModelYear= 1970 },
                new Car {CarId =3, BrandId=2, ColorId=2, DailyPrice = 40000, Description="Hasarlı", ModelYear= 1980 },
                new Car {CarId =4, BrandId=2, ColorId=3, DailyPrice = 50000, Description="Lastikleri bitik", ModelYear= 1990 },
                new Car {CarId =5, BrandId=3, ColorId=4, DailyPrice = 60000, Description="Saglam araç", ModelYear= 2018},
                new Car {CarId =6, BrandId=3, ColorId=4, DailyPrice = 160000, Description="Sıfır Gibi", ModelYear= 2021}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrandId(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}