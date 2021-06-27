using Fork2Common.Model.Enums;

namespace Fork2Common.Model.Packages.Entity
{
    public class StartEntityPackage : AbstractEntityPackage
    {
        public string Guid { get; set; }
        public EntityType EntityType { get; set; }

        public StartEntityPackage() : base(nameof(StartEntityPackage))
        {
        }
    }
}