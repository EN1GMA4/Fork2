using System;
using Fork2Common.Model.Pofo.Settings;

namespace Fork2Common.Model.Pofo.Entity.Server
{
    public class JavaMinecraftServer : AbstractMinecraftServer
    {
        public new JavaSettings EnvironmentSettings
        {
            get => base.EnvironmentSettings as JavaSettings;
            set => base.EnvironmentSettings = value;
        }
        public bool AutoSetSha1 { get; set; } = true;
        public DateTime ResourcePackHashAge { get; set; } = DateTime.MinValue;

        public static JavaMinecraftServer Deserialize(string serialized)
        {
            return AbstractPofo.Deserialize<JavaMinecraftServer>(serialized);
        }
    }
}