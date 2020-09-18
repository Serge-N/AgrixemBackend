using System;

namespace AgrixemAPI.Core.Models.Production.Goats
{
    /// <summary>
    /// This tells us what an invidual Goat eats.....
    /// </summary>
    /// <remarks>At the end of the day, all Goats eat.</remarks>
    public class GoatFeed
    {
        public long ID { get; set; }
        public long GoatID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? StopDate { get; set; }
        public string Feed { get; set; }
        public int? StartingWeight{ get; set; }
        public int? StopingWeight { get; set; }
        public int? Cost { get; set; }
    }
}
