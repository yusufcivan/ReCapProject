using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        //Id, BrandId, ColorId, ModelYear, DailyPrice, Description

        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetAll())
            //foreach (var car in carManager.GetByCarId(1))
            foreach (var car in carManager.GetByUnitPrice(50, 9999999))
            {
                Console.WriteLine(car.Description);
            }


            //CarManager carManager = new CarManager(new InMemoryCarDal());
            //BrandManager brandManager = new BrandManager(new InMemoryBrandDal());
            //ColorManager colorManager = new ColorManager(new InMemoryColorDal());


            //Console.WriteLine("***List of All Cars***");
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine("{0},{1}", brand.BrandId, brand.BrandName);
            //}

            //Console.WriteLine("\n ***List of All Colors***");
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine("{0},{1}", color.ColorId, color.ColorName);
            //}

            //Console.WriteLine("\n ***Car Informations***");
            //foreach (var car in carManager.GetAll()) 
            //{
            //    Console.WriteLine("Car Brand Id : {0}", car.BrandId);
            //    Console.WriteLine("Car Color Id : {0}", car.ColorId);
            //    Console.WriteLine("Car DailyPrice Id : {0}", car.DailyPrice);
            //    Console.WriteLine("Car ModelYear  : {0}", car.ModelYear);
            //    Console.WriteLine("Car Description  : {0}", car.Description);

            }
        }
    }

