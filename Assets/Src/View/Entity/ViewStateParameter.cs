using Assets.Src.Model.Application.Value;
using System.Collections.Generic;
using System.Linq;

#nullable enable
namespace Assets.Src.View.Entity
{
    /// <summary>
    /// ビューパラメータ計算用の諸々の値を持つデータクラス
    /// </summary>
    /// <typeparam name="TValue">パラメータ型</typeparam>
    public class ViewStateParameter<TValue> where TValue : struct
    {
        /// <summary>
        /// 基点値
        /// </summary>
        public TValue basis { get; set; }
        /// <summary>
        /// 変動値パラメータ
        /// </summary>
        public IEnumerable<(Easing easing, int time, TValue final)> progresses { get; set; }
            = Enumerable.Empty<(Easing, int, TValue)>();
    }
}
