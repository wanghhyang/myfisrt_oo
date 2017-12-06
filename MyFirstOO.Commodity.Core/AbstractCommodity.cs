using MyFirstOO.Commodity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOO.Commodity.Core
{
    /// <summary>
    /// 商品抽象类，商品的最底层溯源对象
    /// </summary>
    public abstract class AbstractCommodity
    {
        private CommodityInfo _baseCommodityInfo;
        private string _addtionalCommodityInfo;
        private string[] _products;
        private string[] _packages;
        private string[] _pictures;
        private string[] _attributes;
        private string[] _saleCategorys;
        private decimal price;


        protected abstract void CreateCommodity();
        protected abstract void UpdateCommodity();
    }
}
