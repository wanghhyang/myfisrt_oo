using System;
using MyFirstOO.Commodity.Core.Ingreadient;

namespace MyFirstOO.Commodity.Core.Commodity
{
    public class GongyinglianLYCommodity : AbstractCommodity
    {
        ICommodityIngredientFactory commodityIngredientFactory;
        public GongyinglianLYCommodity(ICommodityIngredientFactory commodityIngredientFactory)
        {
            this.commodityIngredientFactory = commodityIngredientFactory;
        }
        protected override void PreSaveCommodity()
        {
            BaseCommodityInfo = commodityIngredientFactory.CreateBaseInfo();
            Products = commodityIngredientFactory.CreateCommodityProduct();
            Packages = commodityIngredientFactory.CreateCommodityPackages();
        }
        
        protected override void bindProduct()
        {
            throw new NotImplementedException();
        }

        protected override void SetAttribute()
        {
            throw new NotImplementedException();
        }

        protected override void SetPrice()
        {
            throw new NotImplementedException();
        }
    }
}
