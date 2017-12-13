using MyFirstOO.Commodity.Model;

namespace MyFirstOO.Commodity.Core.Commodity
{
    /// <summary>
    /// 商品抽象类，商品的最底层溯源对象
    /// </summary>
    public abstract class AbstractCommodity
    {
        public CommodityBaseInfo BaseCommodityInfo { get; set; }

        public CommodityAddtionalInfo AddionalCommodityInfo { get; set; }

        public CommodityProductInfo[] Products { get; set; }

        public CommodityPackageInfo[] Packages { get; set; }

        public string Pictures { get; set; }

        public string[] Attributes { get; set; }

        public decimal Price { get; set; }

        public void SetBasicFieldInfo()
        {

        }
        public abstract void PreSaveCommodity();
        public abstract void BindProduct();
        public abstract void SetPrice();
        public abstract void SetAttribute();


    }
}
