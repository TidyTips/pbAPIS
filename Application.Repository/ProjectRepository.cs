using Application.DAL.Contracts;
using Application.DAL.Implementations;
using Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
   public class ProjectRepository : Repository<project>, IProjectRepository
    {
        private pbMerchandiseEntities dataContext;

        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        public ProjectRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
            DatabaseFactory = databaseFactory;
        }

        protected pbMerchandiseEntities DataContext
        {
            get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        }

    }
    public interface IProjectRepository : IRepository<project>
    {
    }


}
