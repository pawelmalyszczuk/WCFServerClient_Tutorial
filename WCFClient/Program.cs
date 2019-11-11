using System;
using System.ServiceModel;
using WCFServer;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri url = new Uri("http://localhost:2222/Hello");
            using (var c = new ChannelFactory<IHelloWorld>(
                new BasicHttpBinding(),
                new EndpointAddress(url)))
            {
                var s = c.CreateChannel();
                Console.WriteLine(s.Hello());
                Console.ReadLine();

            } 
        }
    }
}
