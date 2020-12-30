using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable
namespace Assets.Src.Model.Application.Value
{
    /// <summary>
    /// 画面表示系オブジェクトの雛形
    /// </summary>
    public interface IViewKey
    {
        /// <summary>
        /// 実ビューオブジェクト識別用コード
        /// </summary>
        string keyCode { get; }
    }
}
