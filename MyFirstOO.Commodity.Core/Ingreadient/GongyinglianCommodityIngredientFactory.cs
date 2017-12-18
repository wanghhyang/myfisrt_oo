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
            return Commodity.Base;
        }
        public DeptInfo CreateCompanyAndDept()
        {
            return new DeptInfo();
        }

        public OriginInfo CreateOrigin()
        {
            throw new NotImplementedException();
        }
        
        public bool CommodityValidateRule()
        {
            if (string.IsNullOrEmpty(Commodity.Base.CommodityName))
            {
                return false;
            }
            return true;
        }
        
        public CommodityProductInfo[] SetCommodityProducts()
        {
            return new[] { new CommodityProductInfo(), new CommodityProductInfo() };
        }

        public CommodityPackageInfo[] SetCommodityPackages()
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
