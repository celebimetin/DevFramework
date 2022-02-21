using DevFramework.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace DevFramework.Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        Product GeyById(int id);

        Product Add(Product product);

        Product Update(Product product);

        void Delete(Product productId);
    }
}