using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstOO.Commodity.Model;

namespace MyFirstOO.Commodity.Core.Ingreadient
{
    public class GongyinglianLYCommodityIngredientFactory : ICommodityIngredientFactory
    {
        private int _isDearls = 1;
        public CommodityInfo Commodity { get; set; }
        public CommodityBaseInfo CreateBaseInfo()
        {
            throw new NotImplementedException();
        }

        public bool CommodityValidateRule()
        {
            throw new NotImplementedException();
        }

        public CommodityProductInfo[] SetCommodityProducts()
        {
            throw new NotImplementedException();
        }

        public CommodityPackageInfo[] SetCommodityPackages()
        {
            throw new NotImplementedException();
        }

        public string[] CreateCommodityAttributes()
        {
            throw new NotImplementedException();
        }

        public int IsDearls
        {
            get { return _isDearls; }
            set { _isDearls = value; }
        }
    }
}
