using System.IO;
using System.Threading.Tasks;
using ArknightsResources.Operators.Models;

namespace ArknightsResources.CustomResourceHelpers
{
    /// <summary>
    /// 定义一套用以读取与干员Spine动画相关资源的方法
    /// </summary>
    public interface IOperatorSpineAnimationGetter
    {
        /// <summary>
        /// 获取干员的Spine动画
        /// </summary>
        /// <param name="spineInfo">干员Spine动画的相关信息</param>
        /// <returns>一个三元组,第一项为包含atlas信息的<see cref="TextReader"/>,第二项为包含skel信息的<see cref="TextReader"/>,第三项为Spine动画所需的PNG格式图片</returns>
        (TextReader, TextReader, byte[]) GetOperatorSpineAnimation(OperatorSpineInfo spineInfo);

        /// <summary>
        /// 异步获取干员的Spine动画
        /// </summary>
        /// <param name="spineInfo">干员Spine动画的相关信息</param>
        /// <returns>一个三元组,第一项为包含atlas信息的<see cref="TextReader"/>,第二项为包含skel信息的<see cref="TextReader"/>,第三项为Spine动画所需的PNG格式图片</returns>
        Task<(TextReader, TextReader, byte[])> GetOperatorSpineAnimationAsync(OperatorSpineInfo spineInfo);
    }
}