using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Goats
{
    /// <summary>
    /// This class shows us the individual Goat sales
    /// </summary>
    /// <remarks>The GoatID is unque in this case and Non of the fields is to be null.</remarks>
    public class GoatMarket
    {
        public long GoatID { get; set; }
        public Goat Goats { get; set; }
        public int PurchasePrice { get; set; }
        public int SalePrice { get; set; }
        public int SaleWeight { get; set; }
        public string Mode { get; set; }
        public string Customer { get; set; }
    }
}
