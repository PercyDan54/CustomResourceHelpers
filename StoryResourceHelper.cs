﻿using System.Globalization;

namespace ArknightsResources.CustomResourceHelpers
{
    /// <summary>
    /// 定义一个用以读取与剧情相关资源的基类
    /// </summary>
#if NET7_0_OR_GREATER
    [System.Obsolete("在.NET 7及以上版本, 请使用IStoryResourceHelper接口")]
#endif
    public abstract class StoryResourceHelper
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
        /// 通过剧情文件的代号获取该剧情的原始剧情文本
        /// </summary>
        /// <param name="codename">剧情文件的代号</param>
        /// <param name="cultureInfo"></param>
        /// <returns>原始剧情文本</returns>
        public abstract string GetStoryRawText(string codename, CultureInfo cultureInfo);
    }


#if NET7_0_OR_GREATER

    /// <summary>
    /// 定义一系列用以读取与剧情相关资源的方法
    /// </summary>
    public interface IStoryResourceHelper
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
        /// 通过剧情文件的代号获取该剧情的原始剧情文本
        /// </summary>
        /// <param name="codename">剧情文件的代号</param>
        /// <param name="cultureInfo"></param>
        /// <returns>原始剧情文本</returns>
        public static abstract string GetStoryRawText(string codename, CultureInfo cultureInfo);
    }

#endif
}
