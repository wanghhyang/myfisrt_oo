using System;
using MyFirstOO.Commodity.Core.Ingreadient;

namespace MyFirstOO.Commodity.Core.Commodity
{
    public class ZyCommodity : AbstractCommodity
    {
        readonly ICommodityIngredientFactory _commodityIngredientFactory;
        public ZyCommodity(ICommodityIngredientFactory commodityIngredientFactory)
        {
            _commodityIngredientFactory = commodityIngredientFactory;
        }
        protected override void PreSaveCommodity()
        {
            BaseCommodityInfo = _commodityIngredientFactory.CreateBaseInfo();
            AddionalCommodityInfo = _commodityIngredientFactory.SetAddtionalCommodityInfo();
            Attributes = _commodityIngredientFactory.CreateCommodityAttributes();
        }

        protected override void BindProduct()
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
