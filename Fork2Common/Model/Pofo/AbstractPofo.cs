using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Fork2Common.Model.Pofo
{
    /// <summary>
    /// Each Pofo (Plain old fork object) should implement this
    /// A Pofo is every class that can be serialized to send over the WebSocket as Payload
    /// </summary>
    public abstract class AbstractPofo
    {
        private string guid = System.Guid.NewGuid().ToString();

        /// <summary>
        /// Unique identifier for a Pofo (is automatically set at creation time)
        /// </summary>
        public string Guid => guid;

        protected AbstractPofo()
        {
        }

        /// <summary>
        /// Convenience method to serialize a Pofo before sending it across the world
        /// </summary>
        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// Convenience method to deserialize a Pofo after it saw the world
        /// </summary>
        protected static T Deserialize<T>(string serialized) where T : AbstractPofo
        {
            return JsonConvert.DeserializeObject<T>(serialized);
        }
    }
}