using Application.DAL.Contracts;
using Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DAL.Implementations
{
   public class DatabaseFactory : Disposable,IDatabaseFactory
    {
        private pbMerchandiseEntities dataContext;
        public pbMerchandiseEntities Get()
        {
            return dataContext ?? (dataContext = new pbMerchandiseEntities());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }

    }
}
