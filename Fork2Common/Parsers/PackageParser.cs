using Fork2Common.Model.Exceptions;
using Fork2Common.Model.Packages;
using Fork2Common.Model.Packages.Entity;
using Fork2Model.Enums;
using Newtonsoft.Json;

namespace Fork2Common.Parsers
{
    public class PackageParser
    {
        public static AbstractPackage ParsePackage(string packageString)
        {
            dynamic package = JsonConvert.DeserializeObject(packageString);
            string packageType = package.Type;
            switch (packageType)
            {
                case nameof(StartEntityPackage):
                    return JsonConvert.DeserializeObject<StartEntityPackage>(packageString);
                default:
                    throw new ForkException(ErrorMessage.UNKNOWN_PACKAGE);
            }
        }
    }
}