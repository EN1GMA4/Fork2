using Fork2Backend.Model;
using Fork2Common.Model.Enums;
using Fork2Common.Model.Packages;
using Fork2Common.Model.Packages.ConsoleTab;

namespace Fork2Backend.Services
{
    /**
     * Service for managing Fork entities (server, networks)
     */
    public class EntityService : AbstractService
    {
        protected override void HandlePackage(RequestContext context, AbstractPackage package)
        {
            switch (package.Command)
            {
                case Command.START_ENTITY:
                    StartEntity(package as EntityPackage);
                    break;
                default:
                    Log.Debug("Can't handle command: "+package.Command);
                    break;
            }
        }
        
        #region Handlers
        
        private async void StartEntity(EntityPackage package)
        {
            if (package == null)
            {
                Log.Error("Received invalid Package!");
            }
        }

        #endregion
    }
}