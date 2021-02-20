using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.EntityFramwork
{
    public class EfCarDal : EfEntityReposiroryBase<Car, CarRentalContext>,ICarDal
    {
        
    }
}
