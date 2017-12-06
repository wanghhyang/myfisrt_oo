using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOO.Commodity.Core
{
    /// <summary>
    /// 自营公司
    /// </summary>
    public class ZYCommodityIngredientFactory : ICommodityIngredientFactory
    {
        public string CreateCompanyId()
        {
            return "自营公司主体";
        }

        public string CreateInfoValidateRule()
        {
            return "自营公司主体的验证规则";
        }
    }
}
