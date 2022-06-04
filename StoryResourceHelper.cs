using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ArknightsResources.CustomResourceHelpers
{
    /// <summary>
    /// 定义一个用以读取与剧情相关资源的基类
    /// </summary>
    public abstract class StoryResourceHelper
    {
        /// <summary>
        /// 通过剧情文件的代号获取该剧情的原始剧情文本
        /// </summary>
        /// <param name="codename">剧情文件的代号</param>
        /// <param name="cultureInfo"></param>
        /// <returns>原始剧情文本</returns>
        public abstract string GetStoryText(string codename, CultureInfo cultureInfo);
    }
}
