﻿
using Application.DAL.Contracts;
using Application.DAL.Implementations;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System.Web.Http.Controllers;

namespace pbMerchandise.CastleDI
{
    public class DependencyInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                        
                        Component.For<IDatabaseFactory>()
                            .ImplementedBy<DatabaseFactory>()
                            .LifeStyle.PerWebRequest,

                        Component.For<IUnitOfWork>()
                            .ImplementedBy<UnitOfWork>()
                            .LifeStyle.PerWebRequest,

                        AllTypes.FromThisAssembly().BasedOn<IHttpController>().LifestyleTransient(),

                        AllTypes.FromAssemblyNamed("Application.Service")
                            .Where(type => type.Name.EndsWith("Service")).WithServiceAllInterfaces().LifestylePerWebRequest(),

                        AllTypes.FromAssemblyNamed("Application.Repository")
                            .Where(type => type.Name.EndsWith("Repository")).WithServiceAllInterfaces().LifestylePerWebRequest()
                        );
        }

    }
}
