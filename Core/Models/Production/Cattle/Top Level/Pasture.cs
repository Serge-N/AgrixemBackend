using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Cattle
{
    /// <summary>
    /// This class informs us what each cow will eat for a specified period of time.
    /// </summary>
    public class Pasture
    {
        public long ID { get; set; }
        public int FarmID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }
        public string FeedType { get; set; }
        public int? Cost { get; set; }
    }
}
