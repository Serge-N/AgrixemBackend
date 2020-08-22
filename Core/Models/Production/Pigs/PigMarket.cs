using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Pig
{
    /// <summary>
    /// Provide sale records for each animal
    /// </summary>
    /// <remarks>
    /// Each pig is sold once therefor the pigID in this case is unque.
    /// The Mode shows us if the animal was sold as a whole or a Carcus
    /// </remarks>
    public class PigMarket
    {
        public long PigID { get; set; }
        public Pig Pig { get; set; }
        public DateTime DateOfSale { get; set; }
        public int SaleWeight { get; set; }
        public int Price { get; set; }
        public string Mode { get; set; }
    }
}
