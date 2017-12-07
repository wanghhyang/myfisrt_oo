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
        protected override void CreateCommodity()
        {
            this.BaseCommodityInfo = commodityIngredientFactory.CreateBaseInfo();
            this.AddionalCommodityInfo = commodityIngredientFactory.CreateAddtionalCommodityInfo();
            this.Attributes = commodityIngredientFactory.CreateCommodityAttributes();
        }

        protected override void UpdateCommodity()
        {
            throw new NotImplementedException();
        }
    }
}
