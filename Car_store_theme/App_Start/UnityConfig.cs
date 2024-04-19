using Car_store_theme.Data;
using Car_store_theme.Service;
using CarStore.DataLayer.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Car_store_theme
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
             container.RegisterType<IDataFactory, DataFactory>();
             container.RegisterType<IProductService, ProductService>();
             container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IUserRepository, UserRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}