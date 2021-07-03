using Fork2Common.Model.Enums;

namespace Fork2Common.Model.Packages.Entity
{
    public class AbstractEntityPackage : AbstractPackage
    {
        public string Guid { get; set; }
        public EntityType EntityType { get; set; }
        
        protected AbstractEntityPackage() {}
    }
}