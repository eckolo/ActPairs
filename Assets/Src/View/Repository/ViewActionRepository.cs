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
            var viewList = action.viewList.Select(view => view.key).ToList();
            var deployMap = action.layout.GetPositionMap(viewList);

            foreach(var (key, shape) in action.viewList)
            {
                var entity = viewRepository.GetEntity(key);

                if(deployMap.ContainsKey(key))
                {
                    var targetCoordinate = deployMap[key];
                    var parameter = entity.coordinate;
                    var currentTargetDiff = parameter.progresses
                        .Select(prog => prog.final)
                        .Aggregate((max1, max2) => max1 + max2);
                    var currentTarget = parameter.basis + currentTargetDiff;
                    var diff = targetCoordinate - currentTarget;
                    if(diff != Vector2.zero)
                    {
                        var newProgress = (action.easing, 0, diff);
                        parameter.progresses = parameter.progresses.Concat(new[] { newProgress });
                    }
                }
                if(shape.alpha is float targetAlpha)
                {
                    var parameter = entity.alpha;
                    var currentTargetDiff = parameter.progresses.Sum(prog => prog.final);
                    var currentTarget = parameter.basis + currentTargetDiff;
                    var diff = targetAlpha - currentTarget;
                    if(diff != 0)
                    {
                        var newProgress = (action.easing, 0, diff);
                        parameter.progresses = parameter.progresses.Concat(new[] { newProgress });
                    }
                }
                if(shape.size is Vector2 targetSize)
                {
                    var parameter = entity.size;
                    var currentTargetDiff = parameter.progresses
                        .Select(prog => prog.final)
                        .Aggregate((max1, max2) => max1 + max2);
                    var currentTarget = parameter.basis + currentTargetDiff;
                    var diff = targetSize - currentTarget;
                    if(diff != Vector2.zero)
                    {
                        var newProgress = (action.easing, 0, diff);
                        parameter.progresses = parameter.progresses.Concat(new[] { newProgress });
                    }
                }
                if(shape.layer is int targetLayer)
                {
                    var parameter = entity.layer;
                    var currentTargetDiff = parameter.progresses.Sum(prog => prog.final);
                    var currentTarget = parameter.basis + currentTargetDiff;
                    var diff = targetLayer - currentTarget;
                    if(diff != 0)
                    {
                        var newProgress = (action.easing, 0, diff);
                        parameter.progresses = parameter.progresses.Concat(new[] { newProgress });
                    }
                }
            }
            throw new System.NotImplementedException();
        }
    }
}
