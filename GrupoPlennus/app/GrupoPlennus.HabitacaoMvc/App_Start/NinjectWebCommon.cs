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

            //app
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IConjugeAppService>().To<ConjugeAppService>();
            kernel.Bind<IDependenteAppService>().To<DependenteAppService>();
            kernel.Bind<IEntidadeAppService>().To<EntidadeAppService>();
            kernel.Bind<IEntidadeMasterAppService>().To<EntidadeMasterAppService>();
            kernel.Bind<IPessoaAppService>().To<PessoaAppService>();
            kernel.Bind<IEntidadeTiposAppService>().To<EntidadeTiposAppService>();
            kernel.Bind<ISexoAppService>().To<SexoAppService>();
            kernel.Bind<IAplicacoesForaCaixaAppService>().To<AplicacoesForaCaixaAppService>();
            kernel.Bind<IDocumentosComplementaresAppService>().To<DocumentosComplementaresAppService>();
            kernel.Bind<IEstadoCivilAppService>().To<EstadoCivilAppService>();
            kernel.Bind<IGrauInstrucaoAppService>().To<GrauInstrucaoAppService>();
            kernel.Bind<INacionalidadeAppService>().To<NacionalidadeAppService>();
            kernel.Bind<INaturalidadeAppService>().To<NaturalidadeAppService>();
            kernel.Bind<IResidenciaAtualAppService>().To<ResidenciaAtualAppService>();
            kernel.Bind<ITipoImovelAppService>().To<TipoImovelAppService>();
            kernel.Bind<ITipoVeiculoAppService>().To<TipoVeiculoAppService>();


            //services
            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IDependenteService>().To<DependenteService>();
            kernel.Bind<IEntidadeService>().To<EntidadeService>();
            kernel.Bind<IEntidadeMasterService>().To<EntidadeMasterService>();
            kernel.Bind<IPessoaService>().To<PessoaService>();
            kernel.Bind<IConjugeService>().To<ConjugeService>();
            kernel.Bind<IEntidadeTiposService>().To<EntidadeTiposService>();
            kernel.Bind<ISexoService>().To<SexoService>();
            kernel.Bind<IAplicacoesForaCaixaService>().To<AplicacoesForaCaixaService>();
            kernel.Bind<IDocumentosComplementaresService>().To<DocumentosComplementaresService>();
            kernel.Bind<IEstadoCivilService>().To<EstadoCivilService>();
            kernel.Bind<IGrauInstrucaoService>().To<GrauInstrucaoService>();
            kernel.Bind<INacionalidadeService>().To<NacionalidadeService>();
            kernel.Bind<INaturalidadeService>().To<NaturalidadeService>();
            kernel.Bind<IResidenciaAtualService>().To<ResidenciaAtualService>();
            kernel.Bind<ITipoImovelService>().To<TipoImovelService>();
            kernel.Bind<ITipoVeiculoService>().To<TipoVeiculoService>();


            //repositories
            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IConjugeRepository>().To<ConjugeRepository>();
            kernel.Bind<IDependenteRepository>().To<DependenteRepository>();
            kernel.Bind<IEntidadeRepository>().To<EntidadeRepository>();
            kernel.Bind<IEntidadeMasterRepository>().To<EntidadeMasterRepository>();
            kernel.Bind<IPessoaRepository>().To<PessoaRepository>();
            kernel.Bind<IEntidadeTiposRepository>().To<EntidadeTiposRepository>();
            kernel.Bind<ISexoRepository>().To<SexoRepository>();
            kernel.Bind<IAplicacoesForaCaixaRepository>().To<AplicacoesForaCaixaRepository>();
            kernel.Bind<IDocumentosComplementaresRepository>().To<DocumentosComplementaresRepository>();
            kernel.Bind<IEstadoCivilRepository>().To<EstadoCivilRepository>();
            kernel.Bind<IGrauInstrucaoRepository>().To<GrauInstrucaoRepository>();
            kernel.Bind<INacionalidadeRepository>().To<NacionalidadeRepository>();
            kernel.Bind<INaturalidadeRepository>().To<NaturalidadeRepository>();
            kernel.Bind<IResidenciaAtualRepository>().To<ResidencicaAtualRepository>();
            kernel.Bind<ITipoImovelRepository>().To<TipoImovelRepository>();
            kernel.Bind<ITipoVeiculoRepository>().To<TipoVeiculoRepository>();
        }
    }
}
