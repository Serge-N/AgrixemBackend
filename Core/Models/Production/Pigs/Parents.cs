using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Pig
{
    /// <summary>
    /// The parents of Each Pig
    /// </summary>
    /// <remarks>
    /// pigID should not be null, it has to be unque because each pig only Has two parents.
    /// The Other fields can be null to external purchases.
    /// </remarks>
    public class Parents
    {
        public long PigID { get; set; }
        public Pig Pig { get; set; }
        public long? SireID { get; set; }
        public long? DamID { get; set; }
    }
}
