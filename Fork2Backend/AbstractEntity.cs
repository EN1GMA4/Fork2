using System;
using System.IO;
using System.Reflection;
using System.Text;
using log4net;
using log4net.Config;

namespace Fork2Backend
{
    public abstract class AbstractEntity
    {
        protected readonly ILog Log;

        protected AbstractEntity(string name)
        {
            Log = LogManager.GetLogger(name);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlConfigurator.Configure(new FileInfo("Config/log4net.config"));
        }
    }
}