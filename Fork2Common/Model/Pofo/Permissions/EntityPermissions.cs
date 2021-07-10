namespace Fork2Common.Model.Pofo.Permissions
{
    public class EntityPermissions
    {
        private bool editEntity = true;
        private bool readEntity;
        private bool startEntity;
        private bool stopEntity;
        private bool consoleIn;
        private bool managePlayers;
        private bool editSettings;
        private bool readSettings;
        private bool editWorlds;
        private bool readWorlds;
        private bool editPlugins;
        private bool readPlugins;

        /// Server Admin
        public bool EditEntity
        {
            get => editEntity;
            set => editEntity = value;
        }

        public bool ReadEntity
        {
            get => editEntity || readEntity;
            set => readEntity = value;
        }

        public bool StartEntity
        {
            get => editEntity || startEntity;
            set => startEntity = value;
        }

        public bool StopEntity
        {
            get => editEntity || stopEntity;
            set => stopEntity = value;
        }

        public bool ConsoleIn
        {
            get => editEntity || consoleIn;
            set => consoleIn = value;
        }

        public bool ManagePlayers
        {
            get => editEntity || consoleIn || managePlayers;
            set => managePlayers = value;
        }

        public bool EditSettings
        {
            get => editEntity || editSettings;
            set => editSettings = value;
        }

        public bool ReadSettings
        {
            get => editEntity || editSettings || readSettings;
            set => readSettings = value;
        }

        public bool EditWorlds
        {
            get => editEntity || editWorlds;
            set => editWorlds = value;
        }

        public bool ReadWorlds
        {
            get => editEntity || editWorlds || readWorlds;
            set => readWorlds = value;
        }

        public bool EditPlugins
        {
            get => editEntity || editPlugins;
            set => editPlugins = value;
        }

        public bool ReadPlugins
        {
            get => editEntity || editPlugins || readPlugins;
            set => readPlugins = value;
        }
    }
}