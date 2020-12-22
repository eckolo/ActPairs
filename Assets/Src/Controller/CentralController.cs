using Assets.Src.Model.Application.Service;
using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Controller
{
    /// <summary>
    /// 処理全体の中央制御系
    /// </summary>
    public class CentralController
    {
        /// <summary>
        /// メインルーチン制御の実行
        /// </summary>
        /// <returns>イテレータ</returns>
        public async UniTask ExecuteMainRoutine()
        //TODO ビュー（ビューコントローラ）呼び出し処理実装
        //TODO 戦闘処理の呼び出しとか普段のゲームルーチン設計
        {
            Debugger.Log($"{typeof(CentralController).FullName}.{nameof(ExecuteMainRoutine)}()");
        }
    }
}
