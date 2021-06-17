using Fork2Backend.Managers;
using Fork2Model.Packages;

namespace Fork2Backend.Services
{
    public abstract class AbstractService : AbstractEntity
    {
        protected AbstractService(string name) : base(name)
        {
            ServiceManager.Instance.PackageReceivedEvent += HandlePackage;
            Log.Debug("Service initialized");
        }

        protected abstract void HandlePackage(RequestContext context, AbstractPackage package);
    }
}