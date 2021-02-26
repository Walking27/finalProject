using Core.Utilites.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<List<Category>> GetById(int categoryID);
    }
}
