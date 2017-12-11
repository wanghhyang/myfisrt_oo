using System;
using MyFirstOO.Commodity.Model;

namespace MyFirstOO.Commodity.Core.Ingreadient
{
    /// <summary>
    /// 自营公司
    /// </summary>
    public class ZYCommodityIngredientFactory : ICommodityIngredientFactory
    {
        public string CreateCompanyId()
        {
            return "自营公司主体";
        }

        public string CreateInfoValidateRule()
        {
            return "自营公司主体的验证规则";
        }
        

        public string CreateAddtionalCommodityInfo()
        {
            throw new NotImplementedException();
        }

        public string[] CreateCommodityProduct()
        {
            throw new NotImplementedException();
        }

        public string[] CreateCommodityPackages()
        {
            throw new NotImplementedException();
        }

        public string[] CreateCommodityPictures()
        {
            throw new NotImplementedException();
        }

        public string[] CreateCommodityAttributes()
        {
            throw new NotImplementedException();
        }

        public CommodityInfo CreateBaseInfo()
        {
            throw new NotImplementedException();
        }

        public int IsDearls { get; set; }
    }
}
