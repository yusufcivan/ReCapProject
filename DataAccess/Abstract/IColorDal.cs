using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IColorDal
    {
        //GetById, GetAll, Add, Update, Delete 
        //Id, BrandId, ColorId, ModelYear, DailyPrice, Description

        List<Color> GetAll();
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);

    }
}
