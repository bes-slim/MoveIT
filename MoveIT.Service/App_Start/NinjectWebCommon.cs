using System.Linq;
using MoveIT.Service.Core;
using MoveIT.Service.Core.Contracts;
using MoveIT.Service.Core.Contracts.MoveIT;
using MoveIT.Service.Core.MoveIT;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MoveIT.Service.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(MoveIT.Service.App_Start.NinjectWebCommon), "Stop")]

namespace MoveIT.Service.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using System.Collections.Generic;

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
            IList<ISpecialFurnitureRule> specialFurnitureRules = kernel.GetAll<ISpecialFurnitureRule>().ToList();
            IList<ICarsNeededForAreaRule> carsNeededForAreaRules = kernel.GetAll<ICarsNeededForAreaRule>().ToList();
            IList<IOffreCostsRule> offrePriceRules = kernel.GetAll<IOffreCostsRule>().ToList();
            IList<IDistancePriceRule> distancePriceRules = kernel.GetAll<IDistancePriceRule>().ToList();

            kernel.Bind<IOfferPriceCalculator>()
                .To<OffrePriceCalcualtor>()
                .WithConstructorArgument("offrePriceRules", offrePriceRules);

            kernel.Bind<ISpecialFurnitreCalculator>()
                .To<SpecialFurnitreCalculator>()
                .WithConstructorArgument("specialFurnitureRules", specialFurnitureRules);

            kernel.Bind<ICarsNeededCalculator>()
                .To<CarsNeededCalculator>()
                .WithConstructorArgument("carsNeededForAreaRules", carsNeededForAreaRules);


            kernel.Bind<IDistancePriceCalculator>()
               .To<DistancePriceCalculator>()
               .WithConstructorArgument("distancePriceRules", distancePriceRules);
        }        

    }
}
