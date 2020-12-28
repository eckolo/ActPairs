using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Model.Application.Value
{
    /// <summary>
    /// 基準点内での配置パターン
    /// </summary>
    public abstract class ViewLayout
    {
        protected ViewLayout(Vector2 coordinate, SpriteAlignment? pivot = null, float? angle = null)
        {
            this.coordinate = coordinate;
            this.pivot = pivot ?? this.pivot;
            this.angle = angle ?? this.angle;
        }

        /// <summary>
        /// 具体的配置先計算メソッド
        /// </summary>
        /// <param name="viewKeyList">配置処理対象となるビューオブジェクトの一覧</param>
        /// <returns>ビューオブジェクト毎の配置座標一覧</returns>
        public abstract Dictionary<IViewKey, Vector2> GetPositionMap(IList<IViewKey> viewKeyList);

        /// <summary>
        /// 配置座標
        /// </summary>
        public Vector2 coordinate { get; }
        /// <summary>
        /// 基準点
        /// </summary>
        public SpriteAlignment pivot { get; } = SpriteAlignment.Center;
        /// <summary>
        /// 角度（反時計回り）
        /// </summary>
        public float angle { get; } = 0;
    }
}
