﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOO.Commodity.Model
{
    /// <summary>
    /// 商品全信息
    /// </summary>
    public class CommodityInfo
    {
        /// <summary>
        /// 公司主体
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// 基础信息
        /// </summary>
        public CommodityBaseInfo Base { get; set; }
        /// <summary>
        /// 额外信息
        /// </summary>
        public CommodityAddtionalInfo AddtionalInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 原料
        /// </summary>
        public CommodityProductInfo[] Products { get; set; }
        /// <summary>
        /// 辅料
        /// </summary>
        public CommodityPackageInfo[] Packages { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 是否联营
        /// </summary>
        public int IsLianying { get; set; }
        /// <summary>
        /// 责任部门
        /// </summary>
        public int Dept { get; set; }
    }
    [Flags]
    public enum CommodityType
    {
        /// <summary>
        /// 自营商品
        /// </summary>
        Gongyinglian,
        /// <summary>
        /// 联营商品
        /// </summary>
        Chaoshi,
        /// <summary>
        /// youpei
        /// </summary>
        Youpei,
        /// <summary>
        /// 赶海
        /// </summary>
        Ganhai,
        /// <summary>
        /// O2O
        /// </summary>
        O2O
    }
}
