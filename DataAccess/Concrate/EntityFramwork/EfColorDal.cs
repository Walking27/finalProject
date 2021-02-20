using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.EntityFramwork
{
    public class EfColorDal : EfEntityReposiroryBase<Color, CarRentalContext>, IColorDal
    {
        
    }
}
