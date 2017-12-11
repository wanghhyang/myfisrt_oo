using MyFirstOO.Commodity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstOO.Commodity.Core.Commodity;
using MyFirstOO.Commodity.Core.Ingreadient;

namespace MyFirstOO.Commodity.Core.Channel
{
    public class GongyinglianGeneralizedChannel : AbstractGeneralizedChannel
    {
        protected override AbstractCommodity CreateCommodity(CommodityType commodityType)
        {
            AbstractCommodity commodity = null;
            ICommodityIngredientFactory ingredientFactory = new ZYCommodityIngredientFactory();
            if ((commodityType & CommodityType.Ziying) == CommodityType.Ziying)
            {
                commodity = new GongyinglianZYCommodity(ingredientFactory);
            }
            return commodity;
        }
    }
}
