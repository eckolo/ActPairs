using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

#nullable enable
namespace Assets.Src.Model.Application.Value
{
    /// <summary>
    /// ビューの動作定義雛形オブジェクト
    /// </summary>
    public partial class ViewAction
    {
        public ViewAction(
            IList<(IViewKey, ViewShape)> viewList,
            IViewLayout layout,
            Easing easing,
            bool? willBeDestroyed = null)
        {
            this.viewList = viewList ?? throw new ArgumentNullException(nameof(viewList));
            this.layout = layout ?? throw new ArgumentNullException(nameof(layout));
            this.easing = easing ?? throw new ArgumentNullException(nameof(easing));
            this.willBeDestroyed = willBeDestroyed ?? this.willBeDestroyed;
        }

        /// <summary>
        /// 動作対象ビューオブジェクトと形状のセット一覧
        /// </summary>
        public IList<(IViewKey key, ViewShape shape)> viewList { get; }
        /// <summary>
        /// 動作対象目標場所
        /// </summary>
        public IViewLayout layout { get; }
        /// <summary>
        /// 動作処理のイージング
        /// </summary>
        public Easing easing { get; }
        /// <summary>
        /// 最終的にビューを削除するか否か
        /// </summary>
        public bool willBeDestroyed { get; } = false;
    }
}
