﻿using MyFirstOO.Commodity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ICommodityIngredientFactory ingredientFactory = new GongyinglianCommodityIngredientFactory();
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