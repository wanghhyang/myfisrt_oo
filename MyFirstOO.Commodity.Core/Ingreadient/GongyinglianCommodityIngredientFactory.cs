using System;
using MyFirstOO.Commodity.Model;

namespace MyFirstOO.Commodity.Core.Ingreadient
{
    /// <summary>
    /// 供应链商品因素工厂类
    /// </summary>
    public class GongyinglianCommodityIngredientFactory : ICommodityIngredientFactory
    {
        public CommodityBaseInfo CreateBaseInfo()
        {
            var baseInfo = new CommodityBaseInfo
            {
                CategoryInfo = "手机",
                CommodityCode = "10000",
                CommodityId = Guid.NewGuid().ToString(),
                CommodityName = "IPhone X",
                Spec = "黑色128G"
            };
            return baseInfo;
        }
        public int CreateCompanyId()
        {
            return 1;
        }

        public string CreateInfoValidateRule()
        {
            return "自营公司主体的验证规则";
        }


        public string SetAddtionalCommodityInfo()
        {
            return "设置了一些商品扩展信息";
        }

        public CommodityProductInfo[] SetCommodityProduct()
        {
            return new[] { new CommodityProductInfo(), new CommodityProductInfo() };
        }

        public CommodityPackageInfo[] SetCommodityPackages()
        {
            throw new NotImplementedException();
        }

        public string CreateCommodityPictures()
        {
            throw new NotImplementedException();
        }

        public string[] CreateCommodityAttributes()
        {
            throw new NotImplementedException();
        }


        public int IsDearls { get; set; }
    }
}
