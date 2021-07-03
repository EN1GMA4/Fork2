using System.Collections;
using System.Collections.Generic;
using Fleck;
using Fork2Backend.Model;

namespace Fork2Backend.Helpers
{
    public class ConnectionCollection
    {
        private Dictionary<IWebSocketConnection, Client> con2client;
        private Dictionary<Client, IWebSocketConnection> client2con;


        /// <summary>
        /// Get a client to a certain connection
        /// </summary>
        public Client Get(IWebSocketConnection connection)
        {
            return con2client[connection];
        }

        /// <summary>
        /// Get the connection of a certain client
        /// </summary>
        public IWebSocketConnection Get(Client client)
        {
            return client2con[client];
        }

        public void Add(IWebSocketConnection connection, Client client)
        {
            con2client.Add(connection, client);
            client2con.Add(client, connection);
        }

        public void Remove(IWebSocketConnection connection)
        {
            Remove(connection, con2client[connection]);
        }
        
        public void Remove(IWebSocketConnection connection, Client client)
        {
            con2client.Remove(connection);
            client2con.Remove(client);
        }
    }
}