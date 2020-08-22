using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Goats
{
    /// <summary>
    /// This refers to the Goat, as a mother.
    /// </summary>
    /// <remarks>It shows when things happened and the expected results.</remarks>
    public class Doe
    {
        public long ID { get; set; }
        public long GoatID { get; set; }
        public DateTime DateOfMating { get; set; }
        public DateTime DateOfExpectionLate { get; set; }
        public DateTime? DateOfExpectionActual { get; set; }
        public int Kids { get; set; }
        public string Remarks { get; set; }
    }
}
