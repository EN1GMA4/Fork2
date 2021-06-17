using log4net;

namespace Fork2Backend.Managers
{
    public abstract class AbstractManager : AbstractEntity
    {
        private ILog _log;
        protected ILog Log => _log ??= LogManager.GetLogger(GetType().Name);
    }
}