using System;
using System.Collections.Generic;
using Fork2Backend.Managers;
using Fork2Common.Model.Enums;
using Fork2Common.Model.Pofo.Permissions;

namespace Fork2Backend.Model
{
    public class Client
    {
        public string UID { get; }
        public string IP { get; }

        /// <summary>
        /// Indicates whether a Client has authenticated with a token
        /// </summary>
        public bool Authenticated => Permissions != null;
        public ForkPermissions Permissions { get; set; }

        public Client(string ip)
        {
            IP = ip;
            UID = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return IP;
        }
    }
}