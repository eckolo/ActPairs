using System.Collections;
using UnityEngine;

namespace Assets.Src.View.Entity
{
    /// <summary>
    /// ビュー実体のパラメータ定義インターフェース
    /// </summary>
    public interface IViewEntity
    {
        /// <summary>
        /// 座標パラメータ
        /// </summary>
        ViewStateParameter<Vector2> coordinate { get; }
        /// <summary>
        /// 透明度パラメータ
        /// </summary>
        ViewStateParameter<float> alpha { get; }
        /// <summary>
        /// サイズ倍率パラメータ
        /// </summary>
        ViewStateParameter<Vector2> size { get; }
        /// <summary>
        /// 層番号パラメータ
        /// </summary>
        ViewStateParameter<int> layer { get; }
    }
}
