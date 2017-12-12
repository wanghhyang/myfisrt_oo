using MyFirstOO.Commodity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstOO.Commodity.Core.Commodity;

namespace MyFirstOO.Commodity.Core.Channel
{
    /// <summary>
    /// 广义渠道抽象类
    /// </summary>
    public abstract class AbstractGeneralizedChannel
    {
        /// <summary>
        /// 发布商品
        /// </summary>
        /// <param name="commodityType">商品类型</param>
        /// <returns></returns>
        public AbstractCommodity IssuedCommodity(CommodityType commodityType)
        {
            AbstractCommodity commodity = CreateCommodity(commodityType);
            commodity.SetBasicFieldInfo();
            return commodity;
        }
        /// <summary>
        /// 创建商品
        /// </summary>
        /// <param name="commodityType">商品类型</param>
        /// <returns></returns>
        protected abstract AbstractCommodity CreateCommodity(CommodityType commodityType);
    }
}
