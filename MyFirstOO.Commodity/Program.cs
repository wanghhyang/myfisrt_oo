using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstOO.Commodity.Core.Channel;
using MyFirstOO.Commodity.Core.Ingreadient;
using MyFirstOO.Commodity.Model;

namespace MyFirstOO.Commodity
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractGeneralizedChannel abstractGeneralizedChannel = new GongyinglianGeneralizedChannel
            {
                CommodityInfo = new CommodityInfo
                {
                    AddtionalInfo = new CommodityAddtionalInfo { AdditonalInfo = "不需要独立包装" }
                }
            };

            abstractGeneralizedChannel.IssuedCommodity(CommodityType.Ziying);
        }
    }
}
