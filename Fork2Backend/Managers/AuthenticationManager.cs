using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Fork2Backend.Model;
using Fork2Common.Model.Exceptions;
using Fork2Common.Model.Pofo.Permissions;
using Fork2Model.Enums;

namespace Fork2Backend.Managers
{
    public class AuthenticationManager : AbstractManager
    {
        private static AuthenticationManager instance;
        public static AuthenticationManager Instance => instance ??= new AuthenticationManager();

        private Dictionary<string, ForkPermissions> tokens;

        private AuthenticationManager()
        {
            //TODO load permissions from file
            tokens = new();
        }

        /// <summary>
        /// Create RequestContext containing infos about the client
        /// </summary>
        /// <returns>RequestContext</returns>
        public RequestContext CreateRequestContext(Client client)
        {
            return new RequestContext(client);
        }

        //TODO prevent spam for stability reasons
        public void AuthenticateClient(Client client, string token)
        {
            if (tokens.ContainsKey(token))
            {
                client.Permissions = tokens[token];
            }
            else
            {
                throw new ForkException(ErrorMessage.INVALID_TOKEN);
            }
        }

        public void CreateNewToken(ForkPermissions permissions)
        {
            tokens.Add(GenerateToken(), permissions);
            //TODO update token store
        }

        /// <summary>
        /// Generate a cryptographically secure 256 bit long Token
        /// Good luck brute forcing that ;)
        /// </summary>
        /// <returns></returns>
        private string GenerateToken()
        {
            using (RandomNumberGenerator rng = new RNGCryptoServiceProvider())
            {
                byte[] tokenData = new byte[32];
                rng.GetBytes(tokenData);
                
                return Convert.ToBase64String(tokenData);
            }
        }
    }
}