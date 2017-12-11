using System;
using MyFirstOO.Commodity.Core.Ingreadient;

namespace MyFirstOO.Commodity.Core.Commodity
{
    public class GongyinglianZYCommodity : AbstractCommodity
    {
        ICommodityIngredientFactory commodityIngredientFactory;
        public GongyinglianZYCommodity(ICommodityIngredientFactory commodityIngredientFactory)
        {
            this.commodityIngredientFactory = commodityIngredientFactory;
        }
        protected override void PreSaveCommodity()
        {
            BaseCommodityInfo = commodityIngredientFactory.CreateBaseInfo();
            AddionalCommodityInfo = commodityIngredientFactory.CreateAddtionalCommodityInfo();
            Attributes = commodityIngredientFactory.CreateCommodityAttributes();
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
