using System.Collections.Immutable;
using System.Globalization;
using System.Threading.Tasks;
using ArknightsResources.Operators.Models;

namespace ArknightsResources.CustomResourceHelpers
{
    /// <summary>
    /// 定义获取干员相关信息的方法
    /// </summary>
    public interface IOperatorInfoGetter
    {
        /// <summary>
        /// 通过干员名称获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="operatorName">干员名称</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        Operator GetOperator(string operatorName, CultureInfo cultureInfo);

        /// <summary>
        /// 通过干员名称异步获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="operatorName">干员名称</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        Task<Operator> GetOperatorAsync(string operatorName, CultureInfo cultureInfo);

        /// <summary>
        /// 通过干员内部代号获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="imageCodename">干员内部代号</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        Operator GetOperatorWithCodename(string imageCodename, CultureInfo cultureInfo);

        /// <summary>
        /// 通过干员内部代号异步获取其<see cref="Operator"/>对象
        /// </summary>
        /// <param name="imageCodename">干员内部代号</param>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个<see cref="Operator"/>对象</returns>
        Task<Operator> GetOperatorWithCodenameAsync(string imageCodename, CultureInfo cultureInfo);

        /// <summary>
        /// 获取当前可用的全部干员
        /// </summary>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个Key为干员代号，Value为<see cref="Operator"/>对象的字典</returns>
        ImmutableDictionary<string, Operator> GetAllOperators(CultureInfo cultureInfo);

        /// <summary>
        /// 异步获取当前可用的全部干员
        /// </summary>
        /// <param name="cultureInfo"><see cref="Operator"/>对象所使用的语言</param>
        /// <returns>一个Key为干员代号，Value为<see cref="Operator"/>对象的字典</returns>
        Task<ImmutableDictionary<string, Operator>> GetAllOperatorsAsync(CultureInfo cultureInfo);
    }
}