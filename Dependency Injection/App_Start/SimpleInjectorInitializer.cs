using Dependency_Injection.Controllers;

[assembly: WebActivator.PostApplicationStartMethod(typeof(Dependency_Injection.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace Dependency_Injection.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;

    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    using Dependency_Injection.Services.Interfaces;
    using Dependency_Injection.Services;

    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {

            container.Register(typeof(IHomeService), typeof(HomeService));
            container.Register(typeof(ITestService), typeof(TestService));

        }
    }
}