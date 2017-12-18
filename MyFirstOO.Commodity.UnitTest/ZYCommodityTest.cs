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
            ICommodityIngredientFactory commodityIngredientFactory = new GongyinglianZYCommodityIngredientFactory();
            AbstractCommodity commodity = new GongyinglianCommodity(commodityIngredientFactory);
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
