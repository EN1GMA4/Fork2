using System;
using System.IO;
using System.Reflection;
using System.Text;
using log4net;
using log4net.Config;
using log4net.Repository.Hierarchy;

namespace Fork2Backend
{
    /// <summary>
    /// Top most component of the backend which provides a Logger
    /// Not to be confused with AbstractEntity (Servers, Networks, etc)
    /// </summary>
    public abstract class AbstractForkEntity
    {
        private ILog _log;
        protected ILog Log => _log ??= LogManager.GetLogger(GetType().Name);


        protected AbstractForkEntity()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlConfigurator.Configure(new FileInfo("Config/log4net.config"));
        }
    }
}