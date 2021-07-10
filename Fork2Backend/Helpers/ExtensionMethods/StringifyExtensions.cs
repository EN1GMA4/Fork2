using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Fork2Backend.Helpers.ExtensionMethods
{
    /// <summary>
    /// Utils to make beautiful string out of dirty objects
    /// </summary>
    public static class StringifyExtensions
    {
        /// <summary>
        /// Convenience method to convert any object to a readable string 
        /// </summary>
        public static string ToJson(this object o)
        {
            return JsonConvert.SerializeObject(o);
        }
        
        /// <summary>
        /// Convenience method to convert any object to a readable and formatted string 
        /// </summary>
        public static string ToFormattedJson(this object o)
        {
            return JsonConvert.SerializeObject(o, Formatting.Indented);
        }
    }
}