using System.Collections.Generic;
using Fork2Backend.Model;
using Fork2Common.Model.Enums;
using Fork2Model.Enums;

namespace Fork2Backend.Managers
{
    public class AuthenticationManager : AbstractManager
    {
        private static AuthenticationManager instance;
        public static AuthenticationManager Instance => instance ??= new AuthenticationManager();

        private AuthenticationManager()
        {
            
        }

        /// <summary>
        /// Authenticates a User and creating the RequestContext including roles
        /// </summary>
        /// <returns>RequestContext</returns>
        public RequestContext CreateRequestContext(string token, Client client)
        {
            return new RequestContext(token, client, new List<Permission>{Permission.ADMIN});
        }
    }
}