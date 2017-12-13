using MyFirstOO.Commodity.Model;
using MyFirstOO.Commodity.Core.Commodity;
using MyFirstOO.Commodity.Core.Ingreadient;

namespace MyFirstOO.Commodity.Core.Channel
{
    /// <summary>
    /// 供应链广义渠道类
    /// </summary>
    public class GongyinglianGeneralizedChannel : AbstractGeneralizedChannel
    {
        /// <summary>
        /// 实现创建商品
        /// </summary>
        /// <param name="commodityType"></param>
        /// <returns></returns>
        protected override AbstractCommodity CreateCommodity(CommodityType commodityType)
        {
            AbstractCommodity commodity = null;
            ICommodityIngredientFactory ingredientFactory = new GongyinglianCommodityIngredientFactory()
            {
                Commodity=new CommodityInfo()
                {
                    AddtionalInfo=CommodityInfo.AddtionalInfo,
                    Base=CommodityInfo.Base,
                    CompanyId=CommodityInfo.CompanyId,
                    Dept=CommodityInfo.Dept
                }
            };
            if ((commodityType & CommodityType.Ziying) == CommodityType.Ziying)
            {
                commodity = new ZyCommodity(ingredientFactory);
            }
            else if ((commodityType & CommodityType.Lianying) == CommodityType.Lianying)
            {
                commodity = new LyCommodity(ingredientFactory);
            }
            return commodity;
        }
    }
}
