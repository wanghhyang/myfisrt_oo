using System;
using MyFirstOO.Commodity.Core.Validate;
using MyFirstOO.Commodity.Model;

namespace MyFirstOO.Commodity.Core.Ingreadient
{
    /// <summary>
    /// 供应链商品因素工厂类
    /// </summary>
    public class GongyinglianZYCommodityIngredientFactory : ICommodityIngredientFactory
    {
        private int _isDearls;
        private CommodityInfo _commodity;
        private ICommodityValidate _baseCommmCommodityValidate;
        public CommodityInfo Commodity
        {
            get { return _commodity; }
            set { _commodity = value; }
        }

        public GongyinglianZYCommodityIngredientFactory()
        {
            _baseCommmCommodityValidate = new GongyinglianZYCommodityValidate(_commodity);
        }

        public CommodityBaseInfo CreateBaseInfo()
        {
            return Commodity.Base;
        }

        public bool CommodityValidateRule()
        {
            bool basicValidate=_baseCommmCommodityValidate.ValidateCommodity();
            if (!basicValidate) return false;
            
            if (!ValidateProducts())
            {
                return false;
            }
            return true;
        }

        private bool ValidateProducts()
        {
            if (Commodity.Products == null)
            {
                return false;
            }
            foreach (var commodityProductInfo in Commodity.Products)
            {
                if ("原料是否联营" == "联营")
                {
                    return false;
                }
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

        public int IsDearls
        {
            get { return _isDearls; }
            set { _isDearls = value; }
        }
    }
}
