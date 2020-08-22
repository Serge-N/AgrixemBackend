using AgrixemAPI.Core.Models.Production.Chicken;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production
{
    /// <summary>
    /// This class shows all the data on day old chicks.
    /// </summary>
    /// <remarks>
    /// Usually with chicken extra numbers are given in case some die.
    /// Breed = Brand - e.g Ross, Bokomo, ZamChick,.... Others
    /// Note that batch number starts from 1 for each farm ID, hence no real key
    /// </remarks>
    public class Chicks
    {
        public long FarmID { get; set; }
        public long BatchNumber { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public int UnitPurchasePrice { get; set; }
        public int Number { get; set; }
        public int Extra { get; set; }
        public string Breed { get; set; }
        public Sales Sales { get; set; }
    }
}
