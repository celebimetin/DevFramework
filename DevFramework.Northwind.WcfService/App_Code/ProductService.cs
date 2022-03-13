using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.DependencyResolvers.Ninject;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for ProductService
/// </summary>
public class ProductService : IProductService
{
    public ProductService()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private IProductService _productService = InstanceFactory.GetInstance<IProductService>();

    public Product Add(Product product)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        return _productService.GetAll();
    }

    public Product GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void TransactionalOperation(Product product1, Product product2)
    {
        throw new NotImplementedException();
    }

    public Product Update(Product product)
    {
        throw new NotImplementedException();
    }
}