using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstOO.Commodity.Core.Channel;
using MyFirstOO.Commodity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOO.Commodity.Core.Channel.Tests
{
    [TestClass()]
    public class AbstractGeneralizedChannelTests
    {
        [TestMethod()]
        public void IssuedCommodityTest()
        {
            AbstractGeneralizedChannel abstractGeneralizedChannel = new GongyinglianGeneralizedChannel()
            {
                CommodityInfo = new CommodityInfo()
                {
                    Base = new CommodityBaseInfo()
                    {
                        CategoryInfo = "水果",
                        CommodityCode = "C10000",
                        CommodityId = Guid.NewGuid().ToString(),
                        CommodityName = "红心火龙果",
                        Spec = "2斤装"
                    },
                    AddtionalInfo = new CommodityAddtionalInfo()
                    {
                        AdditonalInfo = "不可独立包装"
                    },
                    CompanyId = 1,
                    Dept = 1,
                    IsLianying = 0,
                    Products = new[] { new CommodityProductInfo() {
                        ProductId ="EBAC4D1E-DAAF-42C9-B13A-A9D558F768B6",
                        CommodityProductId ="37EB2C52-348E-44FA-8382-26A684447573",
                        ProductName="越南火龙果",
                        Amount=2
                    }},
                    Price=25
                }
            };
            abstractGeneralizedChannel.IssuedCommodity(CommodityType.Ziying);
            Assert.Fail();
        }
    }
}