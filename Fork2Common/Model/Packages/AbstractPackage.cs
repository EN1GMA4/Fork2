using Fork2Common.Model.Enums;

namespace Fork2Common.Model.Packages
{
    public abstract class AbstractPackage
    {
        public Command Command { get; set; }
        public string Type => GetType().Name;
        public string Message { get; set; }

        protected AbstractPackage()
        {
        }
    }
}