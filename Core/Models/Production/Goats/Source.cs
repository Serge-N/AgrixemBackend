using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Goats
{
    /// <summary>
    /// This class helps us see where the animal came from
    /// </summary>
    /// <remarks>The DoeID and BuckID are null for purchased Goats.</remarks>
    public class Source
    {
        public long GoatID { get; set; }
        public Goat Goats { get; set; }
        public long? DoeID { get; set; }
        public long? BuckID { get; set; }
    }
}
