using Fork2Backend.Managers;
using Fork2Backend.Model;
using Fork2Common.Model.Packages;

namespace Fork2Backend.Services
{
    public abstract class AbstractService : AbstractEntity
    {
        protected AbstractService()
        {
            ServiceManager.Instance.PackageReceivedEvent += HandlePackage;
            Log.Debug("Service initialized");
        }

        protected abstract void HandlePackage(RequestContext context, AbstractPackage package);
    }
}