using Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Contract
{
   public interface IProjectServices
    {
        List<project> GetAllProject();
    }
}
