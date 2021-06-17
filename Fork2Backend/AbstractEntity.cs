using System;
using System.IO;
using System.Reflection;
using System.Text;
using log4net;
using log4net.Config;
using log4net.Repository.Hierarchy;

namespace Fork2Backend
{
    public abstract class AbstractEntity
    {
        private ILog _log;
        protected ILog Log => _log ??= LogManager.GetLogger(GetType().Name);


        protected AbstractEntity()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlConfigurator.Configure(new FileInfo("Config/log4net.config"));
        }
    }
}