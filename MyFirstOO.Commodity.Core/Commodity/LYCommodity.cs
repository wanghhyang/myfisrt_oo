using System;
using MyFirstOO.Commodity.Core.Ingreadient;

namespace MyFirstOO.Commodity.Core.Commodity
{
    public class LyCommodity : AbstractCommodity
    {
        readonly ICommodityIngredientFactory _commodityIngredientFactory;
        public LyCommodity(ICommodityIngredientFactory commodityIngredientFactory)
        {
            _commodityIngredientFactory = commodityIngredientFactory;
        }
        protected override void PreSaveCommodity()
        {
            BaseCommodityInfo = _commodityIngredientFactory.CreateBaseInfo();
            Products = _commodityIngredientFactory.SetCommodityProduct();
            Packages = _commodityIngredientFactory.SetCommodityPackages();
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
