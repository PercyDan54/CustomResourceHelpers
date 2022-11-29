using ArknightsResources.Operators.Models;
using System.Globalization;
using System.Threading.Tasks;

namespace ArknightsResources.CustomResourceHelpers
{
    /// <summary>
    /// 定义一个用以读取与干员相关资源的基类
    /// </summary>
#if NET7_0_OR_GREATER
    [System.Obsolete("在.NET 7及以上版本, 请使用IOperatorResourceHelper接口")]
#endif
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
        /// 意大利语的语言文化信息
        /// </summary>
        public static readonly CultureInfo ItalianCultureInfo = CultureInfo.ReadOnly(new CultureInfo("it-IT", false));

        /// <summary>
        /// 通过干员的立绘信息获取其图片
        /// </summary>
        /// <param name="illustInfo">干员的立绘信息</param>
        /// <returns>一个byte数组,其中包含了干员的图片信息</returns>
        public abstract byte[] GetOperatorImage(OperatorIllustrationInfo illustInfo);

        /// <summary>
        /// 通过干员的立绘信息异步获取其图片
        /// </summary>
        /// <param name="illustInfo">干员的立绘信息</param>
        /// <returns>一个byte数组,其中包含了干员的图片信息</returns>
        public abstract Task<byte[]> GetOperatorImageAsync(OperatorIllustrationInfo illustInfo);

        /// <summary>
        /// 通过干员名称获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="operatorName">干员名称</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        public abstract Operator GetOperator(string operatorName, CultureInfo cultureInfo);

        /// <summary>
        /// 通过干员名称异步获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="operatorName">干员名称</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        public abstract Task<Operator> GetOperatorAsync(string operatorName, CultureInfo cultureInfo);

        /// <summary>
        /// 通过干员图像代号获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="imageCodename">干员图像代号</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        public abstract Operator GetOperatorWithImageCodename(string imageCodename, CultureInfo cultureInfo);

        /// <summary>
        /// 通过干员图像代号异步获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="imageCodename">干员图像代号</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        public abstract Task<Operator> GetOperatorWithImageCodenameAsync(string imageCodename, CultureInfo cultureInfo);

        /// <summary>
        /// 获取全部干员
        /// </summary>
        /// <param name="cultureInfo"><see cref="OperatorsList"/>中对象所使用的语言</param>
        /// <returns>一个<see cref="OperatorsList"/>对象</returns>
        public abstract OperatorsList GetAllOperators(CultureInfo cultureInfo);

        /// <summary>
        /// 异步获取全部干员
        /// </summary>
        /// <param name="cultureInfo"><see cref="OperatorsList"/>中对象所使用的语言</param>
        /// <returns>一个<see cref="OperatorsList"/>对象</returns>
        public abstract Task<OperatorsList> GetAllOperatorsAsync(CultureInfo cultureInfo);
    }

#if NET7_0_OR_GREATER

    /// <summary>
    /// 定义一套用以读取与干员相关资源的方法
    /// </summary>
    public interface IOperatorResourceHelper
    {
        /// <summary>
        /// 通过干员的立绘信息获取其图片
        /// </summary>
        /// <param name="illustInfo">干员的立绘信息</param>
        /// <returns>一个byte数组,其中包含了干员的图片信息</returns>
        public static abstract byte[] GetOperatorImage(OperatorIllustrationInfo illustInfo);

        /// <summary>
        /// 通过干员的立绘信息异步获取其图片
        /// </summary>
        /// <param name="illustInfo">干员的立绘信息</param>
        /// <returns>一个byte数组,其中包含了干员的图片信息</returns>
        public static abstract Task<byte[]> GetOperatorImageAsync(OperatorIllustrationInfo illustInfo);

        /// <summary>
        /// 通过干员名称获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="operatorName">干员名称</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        public static abstract Operator GetOperator(string operatorName, CultureInfo cultureInfo);

        /// <summary>
        /// 通过干员名称异步获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="operatorName">干员名称</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        public static abstract Task<Operator> GetOperatorAsync(string operatorName, CultureInfo cultureInfo);

        /// <summary>
        /// 通过干员图像代号获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="imageCodename">干员图像代号</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        public static abstract Operator GetOperatorWithImageCodename(string imageCodename, CultureInfo cultureInfo);

        /// <summary>
        /// 通过干员图像代号异步获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="imageCodename">干员图像代号</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        public static abstract Task<Operator> GetOperatorWithImageCodenameAsync(string imageCodename, CultureInfo cultureInfo);

        /// <summary>
        /// 获取全部干员
        /// </summary>
        /// <param name="cultureInfo"><see cref="OperatorsList"/>中对象所使用的语言</param>
        /// <returns>一个<see cref="OperatorsList"/>对象</returns>
        public static abstract OperatorsList GetAllOperators(CultureInfo cultureInfo);

        /// <summary>
        /// 异步获取全部干员
        /// </summary>
        /// <param name="cultureInfo"><see cref="OperatorsList"/>中对象所使用的语言</param>
        /// <returns>一个<see cref="OperatorsList"/>对象</returns>
        public static abstract Task<OperatorsList> GetAllOperatorsAsync(CultureInfo cultureInfo);
    }

#endif
}
