using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOO.Commodity.Core
{
    /// <summary>
    /// 决定商品的因素（关键成分）
    /// </summary>
    public interface ICommodityIngredientFactory
    {
        /// <summary>
        /// 创建公司主体
        /// </summary>
        /// <returns></returns>
        string CreateCompanyId();
        /// <summary>
        /// 创建自己的商品信息验证规则
        /// </summary>
        /// <returns></returns>
        string CreateInfoValidateRule();
    }
}
