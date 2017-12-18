using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstOO.Commodity.Core.Commodity;
using MyFirstOO.Commodity.Core.Ingreadient;
using MyFirstOO.Commodity.Model;

namespace MyFirstOO.Commodity.Core.Channel
{
    public class LYGeneralizedChannel : AbstractGeneralizedChannel
    {
        protected override AbstractCommodity CreateCommodity(CommodityType commodityType)
        {
            AbstractCommodity commodity = null;
            ICommodityIngredientFactory commodityIngredient = new ChaoshiCommodityIngredientFactory();

            if ((commodityType & CommodityType.Gongyinglian) == CommodityType.Gongyinglian)
            {
                commodity = new GongyinglianCommodity(commodityIngredient);
            }
            return commodity;
        }
    }
}
