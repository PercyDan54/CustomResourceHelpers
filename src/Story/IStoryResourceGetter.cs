using System.Globalization;
using System.Threading.Tasks;

namespace ArknightsResources.CustomResourceHelpers
{
    /// <summary>
    /// 定义一套用以读取与剧情相关资源的方法
    /// </summary>
    public interface IStoryResourceGetter
    {
#if NET7_0_OR_GREATER
        /// <summary>
        /// 通过文件代号获取一个剧情视频
        /// </summary>
        /// <param name="codename">视频代号</param>
        /// <param name="cultureInfo">视频所使用的语言,如果视频没有特定的语言,则不必传递CultureInfo</param>
        /// <returns>包含有视频数据的byte数组</returns>
        public static abstract byte[] GetVideo(string codename, CultureInfo cultureInfo = null);

        /// <summary>
        /// 通过文件代号异步获取一个剧情视频
        /// </summary>
        /// <param name="codename">视频代号</param>
        /// <param name="cultureInfo">视频所使用的语言,如果视频没有特定的语言,则不必传递CultureInfo</param>
        /// <returns>包含有视频数据的byte数组</returns>
        public static abstract Task<byte[]> GetVideoAsync(string codename, CultureInfo cultureInfo = null);

        /// <summary>
        /// 通过剧情文件的代号获取该剧情的原始剧情文本
        /// </summary>
        /// <param name="codename">剧情文件的代号</param>
        /// <param name="cultureInfo"></param>
        /// <returns>原始剧情文本</returns>
        public static abstract string GetStoryRawText(string codename, CultureInfo cultureInfo);

        /// <summary>
        /// 通过剧情文件的代号异步获取该剧情的原始剧情文本
        /// </summary>
        /// <param name="codename">剧情文件的代号</param>
        /// <param name="cultureInfo"></param>
        /// <returns>原始剧情文本</returns>
        public static abstract Task<string> GetStoryRawTextAsync(string codename, CultureInfo cultureInfo);
#else
        /// <summary>
        /// 通过文件代号获取一个剧情视频
        /// </summary>
        /// <param name="codename">视频代号</param>
        /// <param name="cultureInfo">视频所使用的语言,如果视频没有特定的语言,则不必传递CultureInfo</param>
        /// <returns>包含有视频数据的byte数组</returns>
        byte[] GetVideo(string codename, CultureInfo cultureInfo = null);

        /// <summary>
        /// 通过文件代号异步获取一个剧情视频
        /// </summary>
        /// <param name="codename">视频代号</param>
        /// <param name="cultureInfo">视频所使用的语言,如果视频没有特定的语言,则不必传递CultureInfo</param>
        /// <returns>包含有视频数据的byte数组</returns>
        Task<byte[]> GetVideoAsync(string codename, CultureInfo cultureInfo = null);

        /// <summary>
        /// 通过剧情文件的代号获取该剧情的原始剧情文本
        /// </summary>
        /// <param name="codename">剧情文件的代号</param>
        /// <param name="cultureInfo"></param>
        /// <returns>原始剧情文本</returns>
        string GetStoryRawText(string codename, CultureInfo cultureInfo);

        /// <summary>
        /// 通过剧情文件的代号异步获取该剧情的原始剧情文本
        /// </summary>
        /// <param name="codename">剧情文件的代号</param>
        /// <param name="cultureInfo"></param>
        /// <returns>原始剧情文本</returns>
        Task<string> GetStoryRawTextAsync(string codename, CultureInfo cultureInfo);
#endif
    }
}