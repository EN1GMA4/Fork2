using System;
using Fork2Common.Model.Enums.Entity;
using Fork2Common.Model.Pofo.Entity.Server;

namespace Fork2Common.Helpers.ExtensionMethods
{
    public static class EnumExtensions
    {
        // Get the type of the entity based on the enum
        public static Type GetClassType(this EntityType entityType)
        {
            switch (entityType)
            {
                case EntityType.JAVA_MINECRAFT_SERVER:
                    return typeof(JavaMinecraftServer);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}