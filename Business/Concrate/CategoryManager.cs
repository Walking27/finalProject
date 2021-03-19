using Business.Abstract;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            //İş Kodları
            return new SuccesDataResult<List<Category>>(_categoryDal.GetAll());      
        }

        public IDataResult<List<Category>> GetById(int categoryId)
        {
            return new SuccesDataResult<List<Category>>(_categoryDal.GetAll(c => c.CategoryId == categoryId));
        }
    }
}
