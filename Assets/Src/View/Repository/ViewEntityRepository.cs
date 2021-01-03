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
    public class ViewEntityRepository : IViewEntityRepository
    {
        public IViewEntity GetEntity(IViewKey viewKey) => throw new NotImplementedException();
        public IViewEntity SetEntity(IViewKey viewKey, IViewEntity entity) => throw new NotImplementedException();
    }
}
