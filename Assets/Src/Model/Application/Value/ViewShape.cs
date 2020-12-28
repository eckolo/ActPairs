using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Model.Application.Value
{
    /// <summary>
    /// ビューの形状データオブジェクト
    /// </summary>
    public class ViewShape
    {
        public ViewShape(float? alpha = null, Vector2? size = null, int? layer = null)
        {
            this.alpha = alpha;
            this.size = size;
            this.layer = layer;
        }

        /// <summary>
        /// 透明度
        /// </summary>
        public float? alpha { get; }
        /// <summary>
        /// 縦横サイズ倍率
        /// </summary>
        public Vector2? size { get; }
        /// <summary>
        /// 見かけ上の同一点における層番号
        /// </summary>
        public int? layer { get; }
    }
}
