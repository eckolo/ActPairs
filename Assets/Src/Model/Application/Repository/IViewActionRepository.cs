using Assets.Src.Model.Application.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable
namespace Assets.Src.Model.Application.Repository
{
    /// <summary>
    /// ビューアクションをモデル側から制御するリポジトリのインタフェース
    /// </summary>
    public interface IViewActionRepository
    {
        void SetAction(ViewAction action);
    }
}
