using MyFirstOO.Commodity.Model;

namespace MyFirstOO.Commodity.Core.Commodity
{
    /// <summary>
    /// 商品抽象类，商品的最底层溯源对象
    /// </summary>
    public abstract class AbstractCommodity
    {
        protected CommodityBaseInfo BaseCommodityInfo { get; set; }

        protected string AddionalCommodityInfo { get; set; }

        protected CommodityProductInfo[] Products { get; set; }

        protected CommodityPackageInfo[] Packages { get; set; }

        protected string Pictures { get; set; }

        protected string[] Attributes { get; set; }

        protected decimal Price { get; set; }

        public void SetBasicFieldInfo()
        {

        }
        protected abstract void PreSaveCommodity();
        protected abstract void BindProduct();
        protected abstract void SetPrice();
        protected abstract void SetAttribute();
        
        
    }
}
