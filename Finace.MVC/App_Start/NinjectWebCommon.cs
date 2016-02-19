[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Finance.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Finance.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace Finance.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Finance.Application.Interface;
    using Finance.Application;
    using Finance.Domain.Interfaces.Services;
    using Finance.Domain.Services;
    using Finance.Domain.Interfaces.Repositories;
    using Finance.Infra.Repositories;
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
            kernel.Bind<IReceitasAppService>().To<ReceitasAppService>();
            kernel.Bind<ICategoriaReceitasAppService>().To<CategoriaReceitasAppService>();
            kernel.Bind<IDespesasAppService>().To<DespesasAppService>();
            kernel.Bind<ICategoriaDespesasAppService>().To<CategoriaDespesasAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IReceitasService>().To<ReceitasService>();
            kernel.Bind<IDespesasService>().To<DespesasService>();
            kernel.Bind<ICategoriaDespesasService>().To<CategoriaDespesasService>();
            kernel.Bind<ICategoriaReceitasService>().To<CategoriaReceitasService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IReceitasRepository>().To<ReceitasRepository>();
            kernel.Bind<IDespesaRepository>().To<DespesasRepository>();
            kernel.Bind<ICategoriaDespesasRepository>().To<CategoriaDespesasRepository>();
            kernel.Bind<ICategoriaReceitasRepository>().To<CategoriaReceitasRepository>();
        }
    }
}
