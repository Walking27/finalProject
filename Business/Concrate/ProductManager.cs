using Business.Abstract;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilites.Results;
using DataAccess.Abstract;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;
        ILogger _logger;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
            
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            
            try
            {
                //Business Codes

                _ProductDal.Get(product);

                return new SuccessResault(Messages.ProductAdded);
            }
            catch (Exception exseption)
            {
                _logger.Log();
            }
            return new ErrorResult();
            
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 15)
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
