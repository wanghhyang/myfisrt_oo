﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstOO.Commodity.Model;

namespace MyFirstOO.Commodity.Core.Ingreadient
{
    public class ChaoshiCommodityIngredientFactory : ICommodityIngredientFactory
    {
        public CommodityInfo Commodity { get; set; }

        public CommodityBaseInfo CreateBaseInfo()
        {
            if (Commodity.Base != null)
            {
                return Commodity.Base;
            }
            return new CommodityBaseInfo();
        }

        public DeptInfo CreateCompanyAndDept()
        {
            return new DeptInfo();
        }

        public OriginInfo CreateOrigin()
        {
            throw new NotImplementedException();
        }
        
        public bool CommodityValidateRule()
        {
            if (string.IsNullOrEmpty(Commodity.Base.CommodityName))
            {
                return false;
            }
            return true;
        }
        
        public CommodityProductInfo[] SetCommodityProducts()
        {
            var products = new[] {
                new CommodityProductInfo { ProductId = "1000", ProductName = "原料1", Amount = 1, CommodityProductId = "aaa" },
                new CommodityProductInfo {ProductId="10001",ProductName="原料2",Amount=2,CommodityProductId="bbb"}
            };
            return products;
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
