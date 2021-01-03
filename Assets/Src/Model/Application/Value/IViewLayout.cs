using System.Collections.Generic;
using UnityEngine;

#nullable enable
namespace Assets.Src.Model.Application.Value
{
    /// <summary>
    /// 基準点内での配置パターン
    /// </summary>
    public interface IViewLayout
    {
        /// <summary>
        /// 具体的配置先計算メソッド
        /// </summary>
        /// <param name="viewKeyList">配置処理対象となるビューオブジェクトの一覧</param>
        /// <returns>ビューオブジェクト毎の配置座標一覧</returns>
        Dictionary<IViewKey, Vector2> GetPositionMap(IList<IViewKey> viewKeyList);

        /// <summary>
        /// 配置座標
        /// </summary>
        Vector2 coordinate { get; }
        /// <summary>
        /// 基準点
        /// </summary>
        SpriteAlignment pivot { get; }
        /// <summary>
        /// 角度（反時計回り）
        /// </summary>
        float angle { get; }
    }
}
