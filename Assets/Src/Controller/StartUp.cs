using Assets.Src.Model.Application.Service;
using Cysharp.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable enable
namespace Assets.Src.Controller
{
    /// <summary>
    /// 初期化処理制御系
    /// </summary>
    public class StartUp : MonoBehaviour
    {
        /// <summary>
        /// 最初期起動関数
        /// とりあえず自己生成するだけ
        /// </summary>
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void Initialize()
        {
            Debugger.Log($"{typeof(StartUp).FullName}.{nameof(Initialize)}()");
            var myself = new GameObject(nameof(StartUp), typeof(StartUp));
        }

        /// <summary>
        /// シーン読み込み後に呼ばれるコールバック
        /// </summary>
        async void Start()
        {
            Debugger.Log($"{typeof(StartUp).FullName}.{nameof(Start)}()");
            await SetUp();
        }

        /// <summary>
        /// システム的な初期処理
        /// </summary>
        /// <returns>初期処理正常完了フラグ</returns>
        async UniTask<bool> SetUp()
        {
            Debugger.Log($"{typeof(StartUp).FullName}.{nameof(SetUp)}()");

            try
            {
                var controller = new CentralController();
                await controller.ExecuteMainRoutine();
            }
            catch(Exception error)
            {
                Debugger.LogException(error);
                //デバッグ実行時は原因箇所追いやすくするために直接エラーを投げる
                if(!Debug.isDebugBuild)
                    throw error;
            }
            return true;
        }
    }
}