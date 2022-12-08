using System.Threading.Tasks;
using ArknightsResources.Operators.Models;

namespace ArknightsResources.CustomResourceHelpers
{
    /// <summary>
    /// 定义一套用以读取与干员立绘相关资源的方法
    /// </summary>
    public interface IOperatorIllustrationGetter
    {
#if NET7_0_OR_GREATER
        /// <summary>
        /// 通过干员的立绘信息获取其立绘
        /// </summary>
        /// <param name="illustInfo">干员的立绘信息</param>
        /// <returns>一个byte数组,其中包含了干员的立绘</returns>
        public static abstract byte[] GetOperatorIllustration(OperatorIllustrationInfo illustInfo);

        /// <summary>
        /// 通过干员的立绘信息异步获取其立绘
        /// </summary>
        /// <param name="illustInfo">干员的立绘信息</param>
        /// <returns>一个byte数组,其中包含了干员的立绘</returns>
        public static abstract Task<byte[]> GetOperatorIllustrationAsync(OperatorIllustrationInfo illustInfo);
#else
        /// <summary>
        /// 通过干员的立绘信息获取其立绘
        /// </summary>
        /// <param name="illustInfo">干员的立绘信息</param>
        /// <returns>一个byte数组,其中包含了干员的立绘</returns>
        byte[] GetOperatorIllustration(OperatorIllustrationInfo illustInfo);

        /// <summary>
        /// 通过干员的立绘信息异步获取其立绘
        /// </summary>
        /// <param name="illustInfo">干员的立绘信息</param>
        /// <returns>一个byte数组,其中包含了干员的立绘</returns>
        Task<byte[]> GetOperatorIllustrationAsync(OperatorIllustrationInfo illustInfo);
#endif
    }
}
