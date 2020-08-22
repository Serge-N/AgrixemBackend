using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Pig
{
    /// <summary>
    /// This class helps identify the all pig.
    /// </summary>
    /// <remarks>
    /// The CodeNumber presents what has been given to the pig either an ear target or an ear notch.
    /// The status indidicates if the pig is ready to sale or not.
    /// At the end the day: we must be able to compute the following as herd data.
    /// - Average litter size born and weight.
    /// - Average litter size weaned and weight
    /// - Percenatge of pigs born dead.
    /// - Feed conversion
    /// - Average market index
    /// </remarks>
    public class Pig
    {
        public long PigID { get; set; }
        public int CodeNumber { get; set; }
        public char Sex { get; set; }
        public string Breed { get; set; }
        public long PurchaseValue { get; set; }
        public long? CurrentValue { get; set; }
        public string Status { get; set; }
        public long FarmID { get; set; }
        public Litter Litter { get; set; }
        public Parents Parents { get; set; }
        public PigMarket PigMarket { get; set; }
        public Reproduction Reproduction { get; set; }
    }
}
