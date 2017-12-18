using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstOO.Commodity.Model;

namespace MyFirstOO.Commodity.Core.Validate
{
    public class GongyinglianZYCommodityValidate : ICommodityValidate
    {
        private readonly CommodityInfo _commodityInfo;
        public GongyinglianZYCommodityValidate(CommodityInfo commodityInfo)
        {
            _commodityInfo = commodityInfo;
        }
        public bool ValidateCommodity()
        {
            var baseInfo = _commodityInfo.Base;
            if (string.IsNullOrEmpty(baseInfo.CommodityId))
            {
                return false;
            }
            if (string.IsNullOrEmpty(baseInfo.CommodityCode))
            {
                return false;
            }
            if (string.IsNullOrEmpty(baseInfo.CommodityName))
            {
                return false;
            }
            if (string.IsNullOrEmpty(baseInfo.CategoryInfo))
            {
                return false;
            }
            return true;
        }
    }
}
