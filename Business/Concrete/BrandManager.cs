using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandal = brandDal;
        }
        public List<Brand> GetAll()
        {
            return _brandal.GetAll();
        }
    }
}
