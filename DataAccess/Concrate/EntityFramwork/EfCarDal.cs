using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrate.EntityFramwork
{
    public class EfCarDal : EfEntityReposiroryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDTO> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext()) 
            {
                var result = from p in context.Brands
                             join c in context.Cars
                             on p.BrandId equals c.BrandId
                             select new CarDetailDTO
                             {
                                 BrandId = c.Id,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description
                             };
                return result.ToList();
        }   
        }
    }
}
