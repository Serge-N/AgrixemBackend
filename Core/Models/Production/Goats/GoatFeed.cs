using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public DateTime Date { get; set; }
        public string FeedType { get; set; }
        public int? FeedWeight { get; set; }
    }
}
