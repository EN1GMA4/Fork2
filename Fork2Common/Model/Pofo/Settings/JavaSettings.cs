namespace Fork2Common.Model.Pofo.Settings
{
    public class JavaSettings : AbstractPofo, IEnvironmentSettings
    {
        public int MaxRam { get; set; } = 2048;
        public string JavaPath { get; set; } = "java.exe";
        public string StartupParameters { get; set; }
    }
}