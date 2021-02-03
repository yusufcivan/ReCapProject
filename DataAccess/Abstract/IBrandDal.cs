using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBrandDal
    {
        //GetById, GetAll, Add, Update, Delete 
        //Id, BrandId, ColorId, ModelYear, DailyPrice, Description
        List<Brand> GetAll();

        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);

    }
}
