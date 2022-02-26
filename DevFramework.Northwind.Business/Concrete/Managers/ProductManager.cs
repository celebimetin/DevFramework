using DevFramework.Core.Aspects.Postsharp;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.ValidaitonRules.FluentValidation;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace DevFramework.Northwind.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GeyById(int id)
        {
            return _productDal.Get(p => p.ProdcutId == id);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public void Delete(Product productId)
        {
            _productDal.Delete(productId);
        }
    }
}