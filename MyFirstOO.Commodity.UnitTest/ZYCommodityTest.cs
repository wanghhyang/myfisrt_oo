using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstOO.Commodity.Core;
using MyFirstOO.Commodity.Core.Commodity;
using MyFirstOO.Commodity.Core.Ingreadient;

namespace MyFirstOO.Commodity.Core.Tests
{
    [TestClass()]
    public class ZYCommodityTest
    {
        [TestMethod()]
        public void GongyinglianZYCommodityTest()
        {
            ICommodityIngredientFactory commodityIngredientFactory = new ZYCommodityIngredientFactory();
            AbstractCommodity commodity = new GongyinglianZYCommodity(commodityIngredientFactory);
            //commodity.CreateCommodity();
        }

        [TestMethod()]
        public void CreateCommodityTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateCommodityTest()
        {
            Assert.Fail();
        }
    }
}
