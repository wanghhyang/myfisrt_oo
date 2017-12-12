using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstOO.Commodity.Core.Channel;
using MyFirstOO.Commodity.Model;

namespace MyFirstOO.Commodity
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractGeneralizedChannel abstractGeneralizedChannel = new GongyinglianGeneralizedChannel();
            abstractGeneralizedChannel.IssuedCommodity(CommodityType.Ziying);
        }
    }
}
