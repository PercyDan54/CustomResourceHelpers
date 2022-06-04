using ArknightsResources.Operators.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsResources.CustomResourceHelpers
{
    /// <summary>
    /// 定义一个用以读取与干员相关资源的基类
    /// </summary>
    public abstract class OperatorResourceHelper
    {
        /// <summary>
        /// 通过干员的立绘信息获取其图片
        /// </summary>
        /// <param name="illustrationInfo">干员的立绘信息</param>
        /// <returns>一个byte数组,其中包含了干员的图片信息</returns>
        public abstract byte[] GetOperatorImage(OperatorIllustrationInfo illustrationInfo);

        /// <summary>
        /// 通过干员名称获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="operatorName">干员名称</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象的语言文化</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        public abstract Operator GetOperator(string operatorName, CultureInfo cultureInfo);

        /// <summary>
        /// 通过干员图像代号获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="operatorCodename">干员图像代号</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象的语言文化</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        public abstract Operator GetOperatorWithCodename(string operatorCodename, CultureInfo cultureInfo);

        /// <summary>
        /// 获取全部干员
        /// </summary>
        /// <returns>一个<see cref="Operator"/>数组</returns>
        public abstract Operator[] GetAllOperators(CultureInfo cultureInfo);

        /// <summary>
        /// 异步获取全部干员
        /// </summary>
        /// <returns>一个<see cref="Operator"/>数组</returns>
        public abstract Task<Operator[]> GetAllOperatorsAsync(CultureInfo cultureInfo);
    }
}
