﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DAL.Contracts
{
   public interface IUnitOfWork
    {
        void Commit();
    }
}
