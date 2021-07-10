using Fork2Common.Model.Pofo.Settings;
using Newtonsoft.Json;

namespace Fork2Common.Model.Pofo.Entity
{
    public abstract class AbstractEntity : AbstractPofo
    {
        public bool Initialized { get; set; }
        public IEnvironmentSettings EnvironmentSettings { get; set; }
        public EntityVersion Version { get; set; }
        public string Name { get; set; }
        public bool StartWithFork { get; set; }
        public int ServerIconId { get; set; }

        [JsonIgnore]
        public string FullName => Name + " (" + Version.Version + ")";

        public new string ToString()
        {
            return FullName;
        }
    }
}