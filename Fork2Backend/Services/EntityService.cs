using System;
using System.Runtime.CompilerServices;
using Fork2Backend.Managers;
using Fork2Model.Enums;
using Fork2Model.Packages;
using Fork2Model.Packages.Entity;
using log4net;

namespace Fork2Backend.Services
{
    /**
     * Service for managing Fork entities (server, networks)
     */
    public class EntityService : AbstractService
    {
        private RequestContext _context;
        
        public EntityService() : base(nameof(EntityService))
        {
        }
        
        protected override void HandlePackage(RequestContext context, AbstractPackage package)
        {
            _context = context;
            switch (package.Command)
            {
                case Command.START:
                    StartEntity(package as StartEntityPackage);
                    break;
                default:
                    Log.Debug("Can't handle command: "+package.Command);
                    break;
            }
        }
        
        #region Handlers
        
        private void StartEntity(StartEntityPackage package)
        {
            if (package == null)
            {
                Log.Error("Received invalid Package!");
            }
        }

        #endregion
    }
}