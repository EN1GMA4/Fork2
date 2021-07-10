using System.Collections.Generic;
using Fork2Common.Model.Pofo.Automation;
using Fork2Common.Model.Pofo.Settings;
using Newtonsoft.Json;

namespace Fork2Common.Model.Pofo.Entity.Server
{
    public abstract class AbstractMinecraftServer : AbstractEntity
    {
        public List<AutomationTime> AutomationTimes { get; set; }
    }
}