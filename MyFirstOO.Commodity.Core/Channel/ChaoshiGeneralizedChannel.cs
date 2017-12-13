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
    public class ChaoshiGeneralizedChannel : AbstractGeneralizedChannel
    {
        protected override AbstractCommodity CreateCommodity(CommodityType commodityType)
        {
            AbstractCommodity commodity = null;
            ICommodityIngredientFactory commodityIngredient = new ChaoshiCommodityIngredientFactory();

            if ((commodityType & CommodityType.Ziying) == CommodityType.Ziying)
            {
                commodity = new ZyCommodity(commodityIngredient);
            }
            else if ((commodityType & CommodityType.Lianying) == CommodityType.Lianying)
            {
                commodity = new LyCommodity(commodityIngredient);
            }
            return commodity;
        }
    }
}
