using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Pig
{
    /// <summary>
    /// The food consumption class, this is a group entry.
    /// </summary>
    /// <remarks>The total food consumed per month will be calculated from the number of pigs and the date.</remarks>
    public class PigFeed
    {
        public long ID { get; set; }
        public string FeedType { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfPigs { get; set; }
        public int? Consumed { get; set; }
        public int FarmID { get; set; }
    }
}
