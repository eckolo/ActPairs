using Assets.Src.Model.Application.Value;
using Assets.Src.View.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable
namespace Assets.Src.View.Repository
{
    /// <summary>
    /// <see cref="IViewEntity"/>制御用リポジトリ
    /// </summary>
    public interface IViewEntityRepository
    {
        /// <summary>
        /// ビュー実体の取得処理
        /// </summary>
        /// <param name="viewKey">ビュー索引用キー</param>
        /// <returns>ビュー実体</returns>
        IViewEntity GetEntity(IViewKey viewKey);
        /// <summary>
        /// ビュー実体の新規登録処理
        /// </summary>
        /// <param name="viewKey">ビュー索引用キー</param>
        /// <param name="entity">登録するビュー実体</param>
        /// <returns>登録されたビュー実体</returns>
        IViewEntity SetEntity(IViewKey viewKey, IViewEntity entity);
    }
}
