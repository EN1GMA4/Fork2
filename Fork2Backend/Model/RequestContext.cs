using System.Collections.Generic;
using System.Collections.ObjectModel;
using Fork2Common.Model.Enums;

namespace Fork2Backend.Model
{
    public class RequestContext
    {
        public string Token { get; }
        public Client Client { get; }
        public IReadOnlyCollection<Permission> Roles { get; }
 
        public RequestContext(string token, Client client, List<Permission> roles)
        {
            Token = token;
            Client = client;
            Roles = new ReadOnlyCollection<Permission>(roles);
        }
    }
}