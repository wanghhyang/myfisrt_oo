using MyFirstOO.Commodity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstOO.Commodity.Core.Commodity;

namespace MyFirstOO.Commodity.Core.Channel
{
    public abstract class AbstractGeneralizedChannel
    {
        public AbstractCommodity IssuedCommodity(CommodityType commodityType)
        {
            AbstractCommodity commodity = CreateCommodity(commodityType);
            commodity.SetBasicFieldInfo();
            return commodity;
        }
        protected abstract AbstractCommodity CreateCommodity(CommodityType commodityType);
    }
}
