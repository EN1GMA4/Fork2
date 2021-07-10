namespace Fork2Common.Model.Pofo.Automation
{
    public class AutomationTime : AbstractPofo
    {
        /// <summary>
        /// Determines if the Automation is enabled
        /// </summary>
        public bool Enabled { get; set; }
        
        /// <summary>
        /// The hour in which the Automation gets activated (24h format)
        /// </summary>
        public int Hour { get; set; }
        
        /// <summary>
        /// The minute in which the Automation gets activated
        /// </summary>
        public int Minute { get; set; }
    }
}