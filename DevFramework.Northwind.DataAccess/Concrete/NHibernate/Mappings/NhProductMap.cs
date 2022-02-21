using DevFramework.Northwind.Entities.Concrete;
using FluentNHibernate.Mapping;

namespace DevFramework.Northwind.DataAccess.Concrete.NHibernate.Mappings
{
    public class NhProductMap : ClassMap<Product>
    {
        public NhProductMap()
        {
            Table(@"Products");
            LazyLoad();
            Id(x => x.ProdcutId).Column("ProductID");

            Map(x => x.ProductName).Column("ProductName");
            Map(x => x.QuantityPerUnit).Column("QuantityPerUnit");
            Map(x => x.UnitPrice).Column("UnitPrice");
            Map(x => x.CategoryId).Column("CategoryID");
        }
    }
}