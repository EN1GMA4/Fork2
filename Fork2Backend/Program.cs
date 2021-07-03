using System;
using System.Threading;
using Fork2Backend.Managers;
using Fork2Backend.Services;

namespace Fork2Backend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // Init Services
            ServiceManager.Instance.AddService(new EntityService());
            
            // Startup WebSocket(s)
            using var webSocket = new WebSocket();
            webSocket.Init();

            // Wait until Program end
            Thread.Sleep(10000);

            // Cleanup
        }
    }
}