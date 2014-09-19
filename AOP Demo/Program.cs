using Castle.Windsor;
using Castle.MicroKernel.Registration;
using System;
using Castle.Core;

namespace AOP_Demo
{
    public class Program
    {
        private static IWindsorContainer _container;

        public static void Main(string[] args)
        {


            // This part is the IoC Container that just maps the Interface to the Concrete implementation of it
            _container = new WindsorContainer();
            _container.Register(Component.For<LoggingInterceptor>().ImplementedBy<LoggingInterceptor>());
            _container.Register(Component.For<IUser>().ImplementedBy<User>().Interceptors(InterceptorReference.ForType<LoggingInterceptor>()).Anywhere);
            _container.Register(Component.For<IRole>().ImplementedBy<Role>().Interceptors(InterceptorReference.ForType<LoggingInterceptor>()).Anywhere);
            
            // Getting an instance of the User class
            var user = _container.Resolve<IUser>();
            var role = _container.Resolve<IRole>();




            user.GetUserName();

            Console.WriteLine("\n\n");

            role.GetRoleName();

            Console.ReadLine();

        }

    }
}

