using System;
using MyFirstOO.Commodity.Model;

namespace MyFirstOO.Commodity.Core.Ingreadient
{
    /// <summary>
    /// 供应链商品因素工厂类
    /// </summary>
    public class GongyinglianCommodityIngredientFactory : ICommodityIngredientFactory
    {
        public CommodityInfo Commodity { get; set; }
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

        public bool CommodityValidateRule()
        {
            if (string.IsNullOrEmpty(Commodity.Base.CommodityName))
            {
                return false;
            }
            return true;
        }

        public CommodityAddtionalInfo SetAddtionalCommodityInfo()
        {
            Commodity.AddtionalInfo = new CommodityAddtionalInfo { AdditonalInfo = "不可打包" };
            return Commodity.AddtionalInfo;
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
