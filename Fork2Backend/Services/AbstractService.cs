using Fork2Backend.Managers;
using Fork2Backend.Model;
using Fork2Common.Model.Exceptions;
using Fork2Common.Model.Packages;
using Fork2Common.Model.Pofo.Entity;
using Fork2Common.Model.Pofo.Permissions;
using Fork2Model.Enums;

namespace Fork2Backend.Services
{
    public abstract class AbstractService : AbstractForkEntity
    {
        protected AbstractService()
        {
            ServiceManager.Instance.PackageReceivedEvent += HandlePackage;
            Log.Debug("Service initialized");
        }
        protected abstract void HandlePackage(RequestContext context, AbstractPackage package);

        /// <summary>
        /// Makes sure the current Client has the needed permissions
        /// </summary>
        protected void RequireAdmin(RequestContext context)
        {
            Require(context.Client.Permissions.Admin);
        }
        protected void RequireCreateServer(RequestContext context)
        {
            Require(context.Client.Permissions.CreateServer);
        }
        protected void RequireImportServer(RequestContext context)
        {
            Require(context.Client.Permissions.ImportServer);
        }
        protected void RequireStartEntity(RequestContext context, AbstractEntity entity)
        {
            RequireEntity(context, entity);
            Require(context.Client.Permissions.EntityPermissions[entity.Guid].StartEntity);
        }
        
        protected void RequireStopEntity(RequestContext context, AbstractEntity entity)
        {
            RequireEntity(context, entity);
            Require(context.Client.Permissions.EntityPermissions[entity.Guid].StopEntity);
        }

        private void RequireEntity(RequestContext context, AbstractEntity entity)
        {
            Require(context.Client.Permissions.EntityPermissions.ContainsKey(entity.Guid));
        }
        private void Require(bool condition)
        {
            if (!condition)
            {
                throw new ForkException(ErrorMessage.MISSING_PERMISSION);
            }
        }
    }
}