using MyFirstOO.Commodity.Core.Channel;
using MyFirstOO.Commodity.Model;

namespace MyFirstOO.Commodity.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractGeneralizedChannel abstractGeneralizedChannel = new ZYGeneralizedChannel
            {
                CommodityInfo = new CommodityInfo
                {
                    AddtionalInfo = new CommodityAddtionalInfo { AdditonalInfo = "不需要独立包装" }
                }
            };

            abstractGeneralizedChannel.IssuedCommodity(CommodityType.Gongyinglian);
        }
    }
}
