using Business.Abstract;
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
            _ProductDal.Get(product);

            return new Result(true,"Ürün Eklendi");
        }

        public List<Product> GetAll()
        {
            //İş Kodları
            //Yetkisi Var Mı?

            return _ProductDal.GetAll();
        }

        public List<Product> GetAllByCategoryID(int id)
        {
            return _ProductDal.GetAll(p=>p.CategoryID==id);
        }

        public Product GetById(int productId)
        {
            return _ProductDal.Get(p => p.ProductId == productId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _ProductDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _ProductDal.GetProductDetails();
        }
    }
}
