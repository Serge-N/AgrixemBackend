using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Goats
{
    /// <summary>
    /// This class stores data about goats - the Goat Identification class
    /// </summary>
    /// <remarks>Nothng Much here. The Goat Id is Unque here.</remarks>
    public class Goat
    {
        public long GoatID { get; set; }
        public long FarmID { get; set; }
        public long TagId { get; set; }
        public char Sex { get; set; }
        public int PurchaseValue { get; set; }
        public string Breed { get; set; }
        public string NickName { get; set; }
        public string Status { get; set; }
        public Source Source { get; set; }
        public GoatMarket GoatMarket { get; set; }
        public Kid Kid {get; set;}

    }
}
