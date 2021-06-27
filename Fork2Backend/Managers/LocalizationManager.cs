using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fork2Common;
using Fork2Model.Enums;

namespace Fork2Backend.Managers
{
    public class LocalizationManager : AbstractManager
    {
        private static LocalizationManager instance;
        public static LocalizationManager Instance => instance ??= new LocalizationManager();

        private LocalizationManager()
        {
            Localization = new Localization();
        }
        
        public Localization Localization { get; }
    }
}