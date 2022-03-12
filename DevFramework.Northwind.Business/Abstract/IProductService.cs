using DevFramework.Northwind.Entities.Concrete;
using System.Collections.Generic;
using System.ServiceModel;

namespace DevFramework.Northwind.Business.Abstract
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        List<Product> GetAll();

        [OperationContract]
        Product GeyById(int id);

        [OperationContract]
        Product Add(Product product);

        [OperationContract]
        Product Update(Product product);

        [OperationContract]
        void Delete(Product productId);
    }
}