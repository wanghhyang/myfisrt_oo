using System;
using MyFirstOO.Commodity.Core.Ingreadient;

namespace MyFirstOO.Commodity.Core.Commodity
{
    public class ZyCommodity : AbstractCommodity
    {
        private readonly ICommodityIngredientFactory _commodityIngredientFactory;
        public ZyCommodity(ICommodityIngredientFactory commodityIngredientFactory)
        {
            _commodityIngredientFactory = commodityIngredientFactory;
        }

        public override void PreResolveCommodity()
        {
            BaseCommodityInfo = _commodityIngredientFactory.CreateBaseInfo();
            Attributes = _commodityIngredientFactory.CreateCommodityAttributes();
            Products = _commodityIngredientFactory.SetCommodityProducts();
            Packages = _commodityIngredientFactory.SetCommodityPackages();
        }

        public override void BindProduct()
        {
            throw new NotImplementedException();
        }

        public override void SetAttribute()
        {
            throw new NotImplementedException();
        }

        public override void SetPrice()
        {
            throw new NotImplementedException();
        }
    }
}
