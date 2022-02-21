using DevFramework.Northwind.DataAccess.Concrete.NHibernate;
using DevFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevFramework.DataAccess.Tests.NHibernateTests
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());

            var result = nhProductDal.GetList();

            Assert.AreEqual(79, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_products()
        {
            NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());

            var result = nhProductDal.GetList(p => p.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);
        }

        [TestMethod]
        public void Get_all_returns_all_categories()
        {
            NhCategoryDal nhCategoryDal = new NhCategoryDal(new SqlServerHelper());

            var result = nhCategoryDal.GetList();

            Assert.AreEqual(8, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_categories()
        {
            NhCategoryDal nhCategoryDal = new NhCategoryDal(new SqlServerHelper());

            var result = nhCategoryDal.GetList(p => p.CategoryName.Contains("c"));

            Assert.AreEqual(5, result.Count);
        }
    }
}