using MyFirstOO.Commodity.Model;
using MyFirstOO.Commodity.Core.Commodity;
using MyFirstOO.Commodity.Core.Ingreadient;

namespace MyFirstOO.Commodity.Core.Channel
{
    /// <summary>
    /// 供应链广义渠道类
    /// </summary>
    public class ZYGeneralizedChannel : AbstractGeneralizedChannel
    {
        /// <summary>
        /// 实现创建商品
        /// </summary>
        /// <param name="commodityType"></param>
        /// <returns></returns>
        protected override AbstractCommodity CreateCommodity(CommodityType commodityType)
        {
            AbstractCommodity commodity = null;
            ICommodityIngredientFactory ingredientFactory = new GongyinglianZYCommodityIngredientFactory()
            {
                Commodity= CommodityInfo
            };
            if ((commodityType & CommodityType.Gongyinglian) == CommodityType.Gongyinglian)
            {
                commodity = new GongyinglianCommodity(ingredientFactory);
            }
            else if ((commodityType & CommodityType.Chaoshi) == CommodityType.Chaoshi)
            {
                commodity = new ChaoshiCommodity(ingredientFactory);
            }
            return commodity;
        }
    }
}
