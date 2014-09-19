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
                Console.WriteLine("Logging On Start, Method:" + invocation.Method.Name);
                invocation.Proceed();
                Console.WriteLine("Logging On Success, Method:" + invocation.Method.Name);
            }
            catch (Exception)
            {
                Console.WriteLine("Logging an exception has occurred, Method:" + invocation.Method.Name);
                throw;
            }
            finally
            {
                Console.WriteLine("Logging on Exit, Method:" + invocation.Method.Name);
            }
        }
    }
}