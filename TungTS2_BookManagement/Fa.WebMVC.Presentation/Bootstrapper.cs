using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using Fa.WebMVC.Service;
using Fa.WebMVC.Presentation.Areas.Admin.Controllers;

namespace Fa.WebMVC.Presentation
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();            


            container.RegisterType<ICategory, CategoryService>();
            container.RegisterType<IController, CategoriesController>("Category");

            return container;
        }
    }
}