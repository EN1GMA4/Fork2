using Fork2Common.Model.Enums.Entity;

namespace Fork2Common.Model.Packages.ConsoleTab
{
    /// <summary>
    /// Used to change the state of the entity (start, stop, ...)
    /// Frontend -> Backend
    /// </summary>
    public class EntityPackage : AbstractPackage
    {
        /// <summary>
        /// The GUID of the Entity that is targeted
        /// </summary>
        public string Guid { get; set; }
        public EntityType EntityType { get; set; }
    }
}