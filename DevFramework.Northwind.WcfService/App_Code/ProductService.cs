using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.DependencyResolvers.Ninject;
using DevFramework.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace DevFramework.Northwind.WcfService.App_Code
{
    public class ProductService : IProductService
    {
        IProductService _productService = InstanceFactory.GetInstance<IProductService>();

        public List<Product> GetAll()
        {
            return _productService.GetAll();
        }

        public Product GeyById(int id)
        {
            return _productService.GeyById(id);
        }

        public Product Add(Product product)
        {
            return _productService.Add(product);
        }

        public Product Update(Product product)
        {
            return _productService.Update(product);
        }

        public void Delete(Product productId)
        {
            _productService.Delete(productId);
        }
    }
}