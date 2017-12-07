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
        private decimal price;
        protected CommodityInfo BaseCommodityInfo
        {
            get { return _baseCommodityInfo; }
            set { _baseCommodityInfo = value; }
        }
        protected string AddionalCommodityInfo
        {
            get { return _addtionalCommodityInfo; }
            set { _addtionalCommodityInfo = value; }
        }
        protected string[] Products
        {
            get { return _products; }
            set { _products = value; }
        }
        protected string[] Packages
        {
            get { return _packages; }
            set { _packages = value; }
        }
        protected string[] Pictures
        {
            get { return _pictures; }
            set { _pictures = value; }
        }
        protected string[] Attributes
        {
            get { return _attributes; }
            set { _attributes = value; }
        }
        protected decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        protected abstract void CreateCommodity();
        protected abstract void UpdateCommodity();
    }
}
