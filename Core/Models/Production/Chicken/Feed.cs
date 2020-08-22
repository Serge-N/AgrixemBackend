using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production
{
    /// <summary>
    /// This class shows the feeding habit of chicken
    /// </summary>
    /// <remarks>
    /// From here, with respect to Number of chicks and daily consumption, calculations can be made on the type amount of feed consumpted. this can later be used to make assumption for other types. 
    /// Brand - can be custom together with feed type. After Date - FeedType comes - Starter, Grower, Finisher, this is to avoid asking for the FeedType daily
    /// </remarks>
    public class Feed
    {
        public long ID { get; set; }
        public long BatchNumber { get; set; }
        public DateTime Date { get; set; }
        public string FeedType { get; set; }
        public string Brand { get; set; }
        public int Kgs { get; set; }
    }
}
