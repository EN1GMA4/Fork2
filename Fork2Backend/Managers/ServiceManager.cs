using System.Collections.Generic;
using Fork2Backend.Model;
using Fork2Backend.Services;
using Fork2Common.Model.Packages;

namespace Fork2Backend.Managers
{
    public class ServiceManager : AbstractManager
    {
        private static ServiceManager instance;
        public static ServiceManager Instance => instance ??= new ServiceManager();

        private List<AbstractService> runningServices = new();
        
        public delegate void PackageReceivedHandler(RequestContext context, AbstractPackage package);
        public event PackageReceivedHandler PackageReceivedEvent;

        public void AddService(AbstractService service)
        {
            runningServices.Add(service);
        }

        /// <summary>
        /// Invokes all the Services and calls their "handle" method
        /// This expects all packages to be well formed. If they are not there is a high chance for failure ;)
        /// </summary>
        /// <param name="context"></param>
        /// <param name="package"></param>
        public void InvokeServices(RequestContext context, AbstractPackage package)
        {
            PackageReceivedEvent?.Invoke(context, package);
        }
    }
}