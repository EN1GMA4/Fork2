using System.Collections.Generic;
using System.Collections.ObjectModel;
using Fork2Common.Model.Enums;

namespace Fork2Backend
{
    public class RequestContext
    {
        public string Token { get; }
        public string IP { get; }
        public IReadOnlyCollection<Role> Roles { get; }
 
        public RequestContext(string token, string ip, List<Role> roles)
        {
            Token = token;
            IP = ip;
            Roles = new ReadOnlyCollection<Role>(roles);
        }
    }
}