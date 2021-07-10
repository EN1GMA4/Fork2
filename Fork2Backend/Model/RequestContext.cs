using System.Collections.Generic;
using System.Collections.ObjectModel;
using Fork2Common.Model.Enums;

namespace Fork2Backend.Model
{
    public class RequestContext
    {
        public Client Client { get; }
 
        public RequestContext(Client client)
        {
            Client = client;
        }
    }
}