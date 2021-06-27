using System;
using System.Threading.Tasks;
using Fork2Backend.Managers;
using Fork2Common.Model.Exceptions;

namespace Fork2Backend
{
    public class WebSocket : AbstractEntity
    {
        public void Init()
        {
            // Start WebSocket
        }


        /// <summary>
        /// The WebSocket calls this method with messages it receives
        /// </summary>
        private void HandleMessage(string message)
        {
            Task.Run(() =>
            {
                Log.Debug("Handling message: "+message);
                try
                {
                    HandleMessageInternal(message);
                }
                catch (ForkException e)
                {
                    Log.Error("Encountered an Exception");
                }
                catch (Exception e)
                {

                }
            });
        }

        private async void HandleMessageInternal(string message)
        {
            // Create RequestContext
            RequestContext requestContext = AuthenticationManager.Instance.CreateRequestContext("token", "ip");

            
        }

        private void SendMessage(string client, string message)
        {
            
        }
    }
}