[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(GrupoPlennus.HabitacaoMvc.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(GrupoPlennus.HabitacaoMvc.App_Start.NinjectWebCommon), "Stop")]

namespace GrupoPlennus.HabitacaoMvc.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using GrupoPlennus.Application.Interfaces;
    using GrupoPlennus.Application;
    using GrupoPlennus.Domain.Interfaces.Services;
    using GrupoPlennus.Domain.Services;
    using GrupoPlennus.Domain.Interfaces;
    using GrupoPlennus.Data.Repositories;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            
            kernel.Bind<IConjugeAppService>().To<ConjugeAppService>();
            kernel.Bind<IDependenteAppService>().To<DependenteAppService>();
            kernel.Bind<IEntidadeAppService>().To<EntidadeAppService>();
            kernel.Bind<IEntidadeMasterAppService>().To<EntidadeMasterAppService>();
            kernel.Bind<IPessoaAppService>().To<PessoaAppService>();
            





            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            
            kernel.Bind<IDependenteService>().To<DependenteService>();
            kernel.Bind<IEntidadeService>().To<EntidadeService>();
            kernel.Bind<IEntidadeMasterService>().To<EntidadeMasterService>();
            kernel.Bind<IPessoaService>().To<PessoaService>();
            kernel.Bind<IConjugeService>().To<ConjugeService>();


            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IConjugeRepository>().To<ConjugeRepository>();
            kernel.Bind<IDependenteRepository>().To<DependenteRepository>();
            kernel.Bind<IEntidadeRepository>().To<EntidadeRepository>();
            kernel.Bind<IEntidadeMasterRepository>().To<EntidadeMasterRepository>();
            kernel.Bind<IPessoaRepository>().To<PessoaRepository>();
           
        }        
    }
}
