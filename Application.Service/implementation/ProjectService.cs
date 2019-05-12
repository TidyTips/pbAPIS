using Application.Model;
using Application.Repository;
using Application.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.implementation
{
    public class ProjectService : IProjectServices
    {

        IProjectRepository _ProjectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            this._ProjectRepository = projectRepository;

        }
        public List<project> GetAllProject()
        {

            return _ProjectRepository.GetAll().ToList();
        }
    }
}
