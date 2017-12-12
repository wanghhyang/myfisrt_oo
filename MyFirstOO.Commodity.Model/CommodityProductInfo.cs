using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOO.Commodity.Model
{
    /// <summary>
    /// 商品组成原料
    /// </summary>
    public class CommodityProductInfo
    {
        public string CommodityProductId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Amount { get; set; }
    }
}
