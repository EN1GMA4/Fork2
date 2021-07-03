using System;

namespace Fork2Backend.Model
{
    public class Client
    {
        public string IP { get; }
        public string UID { get; }

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