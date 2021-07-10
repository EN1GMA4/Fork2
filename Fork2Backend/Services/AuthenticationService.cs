using Fork2Backend.Model;
using Fork2Common.Model.Enums;
using Fork2Common.Model.Packages;
using Fork2Common.Model.Packages.Authentication;

namespace Fork2Backend.Services
{
    public class AuthenticationService : AbstractService
    {
        protected override void HandlePackage(RequestContext context, AbstractPackage package)
        {
            switch (package.Command)
            {
                case Command.LOGIN:
                    LoginClient(package as LoginPackage);
                    break;
                default:
                    Log.Debug("Can't handle command: "+package.Command);
                    break;
            }
        }

        private void LoginClient(LoginPackage loginPackage)
        {
            
        }
    }
}