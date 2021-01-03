using System.Collections;
using UnityEngine;

#nullable enable
namespace Assets.Src.View.Entity
{
    /// <summary>
    /// ビュー実体
    /// </summary>
    public abstract class ViewEntity : MonoBehaviour, IViewEntity
    {
        /// <summary>
        /// 座標パラメータ
        /// </summary>
        public ViewStateParameter<Vector2> coordinate { get; }
            = new ViewStateParameter<Vector2> { basis = Vector2.zero };
        /// <summary>
        /// 透明度パラメータ
        /// </summary>
        public ViewStateParameter<float> alpha { get; }
            = new ViewStateParameter<float> { basis = 1f };
        /// <summary>
        /// サイズ倍率パラメータ
        /// </summary>
        public ViewStateParameter<Vector2> size { get; }
            = new ViewStateParameter<Vector2> { basis = Vector2.one };
        /// <summary>
        /// 層番号パラメータ
        /// </summary>
        public ViewStateParameter<int> layer { get; }
            = new ViewStateParameter<int> { basis = 0 };
    }
}
