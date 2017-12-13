using MyFirstOO.Commodity.Model;

namespace MyFirstOO.Commodity.Core.Ingreadient
{
    /// <summary>
    /// 决定商品的因素（关键成分）
    /// </summary>
    public interface ICommodityIngredientFactory
    {
        CommodityInfo Commodity { get; set; }

        /// <summary>
        /// 创建商品基本信息
        /// </summary>
        /// <returns></returns>
        CommodityBaseInfo CreateBaseInfo();
        /// <summary>
        /// 创建公司主体
        /// </summary>
        /// <returns></returns>
        int CreateCompanyId();
        /// <summary>
        /// 创建自己的商品信息验证规则
        /// </summary>
        /// <returns></returns>
        bool CommodityValidateRule();
        /// <summary>
        /// 创建额外的商品信息
        /// </summary>
        /// <returns></returns>
        CommodityAddtionalInfo SetAddtionalCommodityInfo();
        /// <summary>
        /// 创建商品组成原料
        /// </summary>
        /// <returns></returns>
        CommodityProductInfo[] SetCommodityProduct();
        /// <summary>
        /// 创建商品的辅料
        /// </summary>
        /// <returns></returns>
        CommodityPackageInfo[] SetCommodityPackages();
        /// <summary>
        /// 创建商品图片
        /// </summary>
        /// <returns></returns>
        string CreateCommodityPictures();
        /// <summary>
        /// 创建商品属性
        /// </summary>
        /// <returns></returns>
        string[] CreateCommodityAttributes();
        /// <summary>
        /// 是否联营
        /// </summary>
        int IsDearls { get; set; }
    }
}
