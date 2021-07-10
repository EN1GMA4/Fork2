using System;
using Fork2Common.Helpers.ExtensionMethods;
using Fork2Common.Model.Enums.Entity;
using Fork2Common.Model.Pofo.Entity;
using Fork2Common.Model.Pofo.Entity.Server;
using Newtonsoft.Json;

namespace Fork2Common.Model.Packages.ConsoleTab
{
    /// <summary>
    /// Used to update the package at the client
    /// backend -> frontend
    /// </summary>
    public class UpdateEntityPackage : EntityPackage
    {
        public string EntitySerialized { get; set; }

        public AbstractEntity GetEntity()
        {
            switch (EntityType)
            {
                case EntityType.JAVA_MINECRAFT_SERVER:
                    return JavaMinecraftServer.Deserialize(EntitySerialized);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}