
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.EntityFramwork
{
    public class EfCategoryDal : EfEntityReposiroryBase<Category, NorthwindContext>,ICategoryDal
    {
        
    }
}
