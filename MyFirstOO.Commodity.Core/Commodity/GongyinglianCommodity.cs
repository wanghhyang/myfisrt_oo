using System;
using MyFirstOO.Commodity.Core.Ingreadient;
using MyFirstOO.Commodity.Model;

namespace MyFirstOO.Commodity.Core.Commodity
{
    public class GongyinglianCommodity : AbstractCommodity
    {
        private readonly ICommodityIngredientFactory _commodityIngredientFactory;
        public GongyinglianCommodity(ICommodityIngredientFactory commodityIngredientFactory)
        {
            _commodityIngredientFactory = commodityIngredientFactory;
        }

        public override void PreResolveCommodity()
        {
            _commodityIngredientFactory.CommodityValidateRule();
            BaseCommodityInfo = _commodityIngredientFactory.CreateBaseInfo();
            Attributes = _commodityIngredientFactory.CreateCommodityAttributes();
            Products = _commodityIngredientFactory.SetCommodityProducts();
            Packages = _commodityIngredientFactory.SetCommodityPackages();
        }

        public override void BindProduct()
        {
        }

        public override void SetAttribute()
        {
        }

        public override void SetPrice()
        {
            throw new NotImplementedException();
        }
    }
}
