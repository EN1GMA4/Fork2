using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Fleck;
using Fork2Backend.Helpers;
using Fork2Backend.Helpers.ExtensionMethods;
using Fork2Backend.Managers;
using Fork2Backend.Model;
using Fork2Common.Model.Exceptions;
using Fork2Common.Model.Packages;
using Fork2Common.Parsers;
using Fork2Model.Enums;

namespace Fork2Backend
{
    public class WebSocket : AbstractForkEntity, IDisposable
    {
        private WebSocketServer server;
        private ConnectionCollection connections = new();
        
        public void Init()
        {
            FleckLog.Level = LogLevel.Debug;
            FleckLog.LogAction = (level, message, ex) =>
            {
                switch (level)
                {
                    case LogLevel.Debug:
                        Log.Debug(message, ex);
                        break;
                    case LogLevel.Error:
                        Log.Error(message, ex);
                        break;
                    case LogLevel.Warn:
                        Log.Warn(message, ex);
                        break;
                    default:
                        Log.Info(message, ex);
                        break;
                }
            };
            
            // Start WebSocket
            server = new WebSocketServer("ws://0.0.0.0:8181");
            server.Start(socket =>
            {
                socket.OnOpen = () => OnOpen(socket);
                socket.OnClose = () => OnClose(socket);
                socket.OnMessage = message => OnMessage(message, socket);
                socket.OnPing = ping => OnPing(ping, socket);
            });
        }

        public void Dispose()
        {
            server?.Dispose();
        }

        public void SendPackage(Client receiver, AbstractPackage package)
        {
            
        }

        public void BroadcastPackage(AbstractPackage package)
        {
            
        }

        /// <summary>
        /// WebSocket Opened
        /// </summary>
        private void OnOpen(IWebSocketConnection socket)
        {
            Log.Debug("WebSocket opened");
            connections.Add(socket, new Client(socket.ConnectionInfo.ClientIpAddress));
            Log.Info("Client "+connections.Get(socket)+" connected!");
        }

        /// <summary>
        /// WebSocket Closed
        /// </summary>
        private void OnClose(IWebSocketConnection socket)
        {
            Log.Debug("WebSocket closed");
            Log.Info("Client "+connections.Get(socket)+" disconnected!");
            connections.Remove(socket);
        }

        /// <summary>
        /// WebSocket got pinged
        /// </summary>
        private void OnPing(byte[] ping, IWebSocketConnection socket)
        {
            Log.Debug("Pinged with: "+Encoding.ASCII.GetString(ping));
            socket.SendPong(Encoding.ASCII.GetBytes("Pong"));
        }

        /// <summary>
        /// The WebSocket calls this method with messages it receives
        /// </summary>
        private void OnMessage(string message, IWebSocketConnection socket)
        {
            Task.Run(() =>
            {
                Log.Debug("Handling message from: "+socket.ConnectionInfo.ClientIpAddress+" with message: "+message);

                // Create RequestContext
                RequestContext requestContext = AuthenticationManager.Instance.CreateRequestContext(connections.Get(socket));
                try
                {
                    HandleMessageInternal(requestContext, message);
                }
                catch (ForkException e)
                {
                    Log.Error("Encountered an Exception: "+ e.Message.Localize());
                    //TODO send error message to frontend
                }
                catch (Exception e)
                {
                    Log.Error("Encountered an unknown Exception: "+e.Message);
                    //TODO send error message to frontend
                    //TODO send log to server for debug
                }
            });
        }

        private void HandleMessageInternal(RequestContext requestContext, string message)
        {
            if (!requestContext.Client.Authenticated)
            {
                Log.Debug("Client "+requestContext.Client+" is not authenticated yet. Expecting Login Package!");
            }
            else
            {
                Log.Debug("Client "+requestContext.Client+ " is authenticated and has following permissions: "+requestContext.Client.Permissions.ToJson());
            }
            ServiceManager.Instance.InvokeServices(requestContext, PackageParser.ParsePackage(message));
        }

        private void SendMessage(Client client, string message)
        {
            
        }

        private string GetToken(IWebSocketConnection socket)
        {
            try
            {
                return socket.ConnectionInfo.Headers["token"];
            }
            catch (Exception)
            {
                throw new ForkException(ErrorMessage.MISSING_TOKEN);
            }
        }
    }
}