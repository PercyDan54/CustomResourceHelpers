﻿using ArknightsResources.Operators.Models;
using System.Globalization;
using System.Threading.Tasks;

namespace ArknightsResources.CustomResourceHelpers
{
    /// <summary>
    /// 定义一个用以读取与干员相关资源的基类
    /// </summary>
    public abstract class OperatorResourceHelper
    {
        /// <summary>
        /// 简体中文的语言文化信息
        /// </summary>
        public static readonly CultureInfo ChineseSimplifiedCultureInfo = CultureInfo.ReadOnly(new CultureInfo("zh-CN", false));
        /// <summary>
        /// 繁体中文的语言文化信息
        /// </summary>
        public static readonly CultureInfo ChineseTraditionalCultureInfo = CultureInfo.ReadOnly(new CultureInfo("zh-TW", false));
        /// <summary>
        /// 英语的语言文化信息
        /// </summary>
        public static readonly CultureInfo EnglishCultureInfo = CultureInfo.ReadOnly(new CultureInfo("en-US", false));
        /// <summary>
        /// 日语的语言文化信息
        /// </summary>
        public static readonly CultureInfo JapaneseCultureInfo = CultureInfo.ReadOnly(new CultureInfo("ja-JP", false));
        /// <summary>
        /// 韩语的语言文化信息
        /// </summary>
        public static readonly CultureInfo KoreanCultureInfo = CultureInfo.ReadOnly(new CultureInfo("ko-KR", false));

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
        /// <param name="operatorImageCodename">干员图像代号</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象的语言文化</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        public abstract Operator GetOperatorWithImageCodename(string operatorImageCodename, CultureInfo cultureInfo);

        /// <summary>
        /// 获取全部干员
        /// </summary>
        /// <returns>一个<see cref="Operator"/>数组</returns>
        public abstract OperatorsList GetAllOperators(CultureInfo cultureInfo);

        /// <summary>
        /// 异步获取全部干员
        /// </summary>
        /// <returns>一个<see cref="Operator"/>数组</returns>
        public abstract Task<OperatorsList> GetAllOperatorsAsync(CultureInfo cultureInfo);
    }
}
