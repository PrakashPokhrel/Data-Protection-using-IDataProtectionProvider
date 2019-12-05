using System;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;
namespace DataProtection
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDataProtection();
            var services = serviceCollection.BuildServiceProvider();
            var instance = ActivatorUtilities.CreateInstance<TestClass>(services);
            instance.RunSample();
        }
        public class TestClass
        {
            IDataProtector _protector;
            // the 'ObjProvider' parameter is provided by DI  
            public TestClass(IDataProtectionProvider ObjProvider)
            {
                _protector = ObjProvider.CreateProtector("Prakash");
            }
            public void RunSample()
            {
                //Read Inputs
                Console.Write("Enter input: ");
                string input = Console.ReadLine();
                //Protect
                string Stringprotected = _protector.Protect(input);
                Console.WriteLine($"Protected String: {Stringprotected}");
                //Unprotect
                string StringUnProtected = _protector.Unprotect(Stringprotected);
                Console.WriteLine($"Unprotected String: {StringUnProtected}");
                Console.ReadLine();
            }
        }
    }
}
