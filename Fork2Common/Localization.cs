using System;
using System.IO;
using System.Linq;
using Fork2Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Fork2Common
{
    /// <summary>
    /// This class provides methods that allow to generate a localized Label for all kinds of enums
    /// </summary>
    public class Localization
    {
        private JObject errorMessages;
        
        /// <summary>
        /// This is a heavy constructor as it loads all resource files into memory
        /// </summary>
        public Localization()
        {
            string errorMessageJson = File.ReadAllText("pack://application:,,,/Resources/Localization/ErrorMessages.json");
            errorMessages = JObject.Parse(errorMessageJson);
        }

        public string Localize(Language language, Enum enumToLocalize)
        {
            if (enumToLocalize is ErrorMessage errorMessage)
            {
                return LocalizeErrorMessage(language, errorMessage);
            }
            
            throw new ArgumentException(enumToLocalize+" is not supported for localization");
        }

        private string LocalizeErrorMessage(Language language, ErrorMessage errorMessage)
        {
            try
            {
                if (errorMessages.ContainsKey(errorMessage.ToString()))
                {
                    var obj = errorMessages[errorMessage.ToString()];
                    return obj[language.ToString()] != null ? obj[language.ToString()].ToString()  : obj[Language.ENGLISH.ToString()].ToString();
                }

                throw new ArgumentException("Couldn't find Key for ErrorMessage " + errorMessage +
                                            " in localization JSON!");
            }
            catch (Exception e)
            {
                throw new ArgumentException("Error localizing ErrorMessage " + errorMessage + " for language " +
                                            language+"! Message: "+e.Message);
            }
        }
    }
}