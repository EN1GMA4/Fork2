using Fork2Common.Model.Exceptions;
using Fork2Common.Model.Packages;
using Fork2Common.Model.Packages.ConsoleTab;
using Fork2Model.Enums;
using Newtonsoft.Json;

namespace Fork2Common.Parsers
{
    public class PackageParser
    {
        public static AbstractPackage ParsePackage(string packageString)
        {
            dynamic package = JsonConvert.DeserializeObject(packageString);
            return package; // As long as the provided string is a valid package this works (I hope^^)
            string packageType = package.Type;
            switch (packageType)
            {
                case nameof(EntityPackage):
                    return (EntityPackage)package;
                default:
                    throw new ForkException(ErrorMessage.UNKNOWN_PACKAGE);
            }
        }
    }
}