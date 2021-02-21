using Business.Abstract;
using Business.Constants;
using Core.Utilites.Results;
using DataAccess.Abstract;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public IResult Add(Product product)
        {
            //business codes
            if (product.ProductName.Length < 2)
            {
                //magic strings
                return new ErrorDataResult<List<Product>>(Messages.ProductNameInvalid);
            }
            _ProductDal.Get(product);

            return new SuccessResault(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }


            return new SuccesDataResult<List<Product>>(_ProductDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryID(int id)
        {

            return new SuccesDataResult<List<Product>>(_ProductDal.GetAll(p => p.CategoryID == id));

        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccesDataResult<Product>(_ProductDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccesDataResult<List<Product>>(_ProductDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }


        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccesDataResult<List<ProductDetailDto>>(_ProductDal.GetProductDetails());

        }
    }
}
