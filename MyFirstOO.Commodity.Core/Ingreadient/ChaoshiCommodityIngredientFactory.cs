using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstOO.Commodity.Model;

namespace MyFirstOO.Commodity.Core.Ingreadient
{
    public class ChaoshiCommodityIngredientFactory : ICommodityIngredientFactory
    {
        public CommodityBaseInfo CreateBaseInfo()
        {
            throw new NotImplementedException();
        }

        public int CreateCompanyId()
        {
            throw new NotImplementedException();
        }

        public string CreateInfoValidateRule()
        {
            throw new NotImplementedException();
        }

        public string SetAddtionalCommodityInfo()
        {
            throw new NotImplementedException();
        }

        public CommodityProductInfo[] SetCommodityProduct()
        {
            throw new NotImplementedException();
        }

        public CommodityPackageInfo[] SetCommodityPackages()
        {
            throw new NotImplementedException();
        }

        public string CreateCommodityPictures()
        {
            throw new NotImplementedException();
        }

        public string[] CreateCommodityAttributes()
        {
            throw new NotImplementedException();
        }

        public int IsDearls { get; set; }
    }
}
