using System.Collections.Generic;

namespace Fork2Common.Model.Pofo.Permissions
{
    public class ForkPermissions
    {
        private bool admin = true;
        private bool forkSettings;
        private bool readForkSettings;
        private bool readGeneralForkSettings;
        private bool readAdvancedForkSettings;
        private bool readDiscordBotSettings;
        private bool readTokenSettings;
        private bool writeForkSettings;
        private bool writeGeneralForkSettings;
        private bool writeAdvancedForkSettings;
        private bool writeDiscordBotSettings;
        private bool writeTokenSettings;
        private bool createServer;
        private bool importServer;
        
        
        /// All permissions
        public bool Admin
        {
            get => admin;
            set => admin = value;
        }
        
        
        /// Full permissions for Fork Settings
        public bool ForkSettings
        {
            get => Admin || forkSettings;
            set => forkSettings = value;
        }
        
        /// Read all Fork Settings
        public bool ReadForkSettings {
            get => Admin || forkSettings || readForkSettings;
            set => readForkSettings = value;
        }
        /// Read specific Fork Settings
        public bool ReadGeneralForkSettings {
            get => Admin || forkSettings || readForkSettings || readGeneralForkSettings;
            set => readGeneralForkSettings = value;
        }
        public bool ReadAdvancedForkSettings {
            get => Admin || forkSettings || readForkSettings || readAdvancedForkSettings;
            set => readAdvancedForkSettings = value;
        }
        public bool ReadDiscordBotSettings {
            get => Admin || forkSettings || readForkSettings || readDiscordBotSettings;
            set => readDiscordBotSettings = value;
        }
        public bool ReadTokenSettings {
            get => Admin || forkSettings || readForkSettings || readTokenSettings;
            set => readTokenSettings = value;
        }
        
        /// Write all Fork Settings
        public bool WriteForkSettings {
            get => Admin || forkSettings || writeForkSettings;
            set => writeForkSettings = value;
        }
        /// Write specific Fork Settings
        public bool WriteGeneralForkSettings {
            get => Admin || forkSettings || writeForkSettings || writeGeneralForkSettings;
            set => writeGeneralForkSettings = value;
        }
        public bool WriteAdvancedForkSettings {
            get => Admin || forkSettings || writeForkSettings || writeAdvancedForkSettings;
            set => writeAdvancedForkSettings = value;
        }
        public bool WriteDiscordBotSettings {
            get => Admin || forkSettings || writeForkSettings || writeDiscordBotSettings;
            set => writeDiscordBotSettings = value;
        }
        public bool WriteTokenSettings {
            get => Admin || forkSettings || writeForkSettings || writeTokenSettings;
            set => writeTokenSettings = value;
        }
        
        
        /// Fork specific permissions
        public bool CreateServer {
            get => Admin || createServer;
            set => createServer = value;
        }
        public bool ImportServer {
            get => Admin || importServer;
            set => importServer = value;
        }

        /// Server specific permissions
        public Dictionary<string, EntityPermissions> EntityPermissions { get; } = new();
    }
}