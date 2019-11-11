using System;
using System.ServiceModel;

namespace WCFServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("http://localhost:2222/Hello");
            ServiceHost host = new ServiceHost(typeof(HelloWorld), uri);
            host.AddServiceEndpoint(typeof(IHelloWorld), new BasicHttpBinding(), uri);
            host.Open();
            Console.WriteLine("Server running...");
            Console.ReadLine();
        }
    }
}
