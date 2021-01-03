using Assets.Src.Model.Application.Value;
using Assets.Src.View.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.View.Factory
{
    /// <summary>
    /// <see cref="IViewEntity"/>生成系
    /// </summary>
    public interface IViewEntityFactory
    {
        /// <summary>
        /// ビュー実体の生成処理
        /// </summary>
        /// <param name="viewKey">生成するビュー実体に紐づける索引用キー</param>
        /// <returns>生成されたビュー実体</returns>
        IViewEntity GenerateEntity(IViewKey viewKey);
    }
}
