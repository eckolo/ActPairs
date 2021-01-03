using Assets.Src.Model.Application.Repository;
using Assets.Src.Model.Application.Value;
using Assets.Src.View.Factory;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable enable
namespace Assets.Src.View.Repository
{
    /// <summary>
    /// ビューアクション制御リポジトリ
    /// </summary>
    public class ViewActionRepository : IViewActionRepository
    {
        public ViewActionRepository(
            IViewEntityRepository viewRepository,
            IViewEntityFactory viewFactory)
        {
            this.viewRepository = viewRepository;
            this.viewFactory = viewFactory;
        }

        /// <summary>
        /// ビュー実体アクセス用リポジトリ
        /// </summary>
        private readonly IViewEntityRepository viewRepository;
        /// <summary>
        /// ビュー実体生成処理系
        /// </summary>
        private readonly IViewEntityFactory viewFactory;

        public void SetAction(ViewAction action)
        {
            throw new System.NotImplementedException();
        }
    }
}
