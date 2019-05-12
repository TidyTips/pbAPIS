using Application.Model;
using Application.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace pbMerchandise.Controllers
{
    public class ProjectController :  ApiController
    {
        IProjectServices _projectServices;
        public ProjectController(IProjectServices projectServices)
        {
            _projectServices = projectServices;
        }

        [System.Web.Http.HttpGet]
       public List<project> GetAllProject()
        {
         return   _projectServices.GetAllProject();

        }
    }
}