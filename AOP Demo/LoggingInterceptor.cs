using System;
using Castle.DynamicProxy;

namespace AOP_Demo
{
    public class LoggingInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            try
            {
                Console.WriteLine("Logging On Start");
                invocation.Proceed();
                Console.WriteLine("Logging On Success");
            }
            catch (Exception e)
            {
                Console.WriteLine("Logging an exception has occurred");
                throw e;
            }
            finally
            {
                Console.WriteLine("Logging on Exit");
            }
        }
    }
}