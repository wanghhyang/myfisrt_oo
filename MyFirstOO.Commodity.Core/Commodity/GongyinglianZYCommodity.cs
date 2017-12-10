using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOO.Commodity.Core
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
