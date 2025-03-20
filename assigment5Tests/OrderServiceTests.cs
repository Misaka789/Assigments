using Microsoft.VisualStudio.TestTools.UnitTesting;
using assigment5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
       
        [TestMethod()]
        public void QueryByIdTest()
        {
            List<Order> TestList = new List<Order>();
            TestList.Add(new Order("123", "name1", "clientName1", 250));
            var service = new OrderService(TestList);
            var result = service.QueryById("123");
            Assert.AreEqual(result.GetId(),"123");
            Assert.AreEqual(result.GetName(),"name1");
            Assert.AreEqual(result.GetClientName(),"clientName1");
            Assert.IsNull(service.QueryById("1234"));
        }

        [TestMethod()]
        public void QueryByNameTest()
        {
            List<Order> TestList = new List<Order>();
            TestList.Add(new Order("123", "name1", "clientName1", 250));
            var service = new OrderService(TestList);
           // Assert.AreEqual(service.QueryByName("name1"),new List<Order>() { };
            Assert.IsNull(service.QueryByName("name2"));
        }

        [TestMethod()]
        public void QueryByClientNameTest()
        {
            List<Order> TestList = new List<Order>();
            TestList.Add(new Order("123", "name1", "clientName1", 250));
            var service = new OrderService(TestList);
            Assert.IsNull(service.QueryByClientName("clientName2"));
        }

        [TestMethod()]
        public void QueryByAmountTest()
        {
            List<Order> TestList = new List<Order>();
            TestList.Add(new Order("123", "name1", "clientName1", 250));
            var service = new OrderService(TestList);
            //Assert.AreEqual(service.QueryByName("123").,"")
        }

        [TestMethod()]   
        public void DeleteByIdTest()
        {
            Assert.Fail();         
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModifyByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SortTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SortTest1()
        {
            Assert.Fail();
        }
    }
}