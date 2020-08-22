using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Pig
{
    /// <summary>
    /// Providing Breeding Dates for Reproduction of each pig - as a mother
    /// </summary>
    /// <remarks>The Breeding class will have many records of reproduction.</remarks>
    public class Breeding
    {
        public long ID { get; set; }
        public long ReproductionID { get; set; }
        public DateTime Date { get; set; }
        public string Remarks { get; set; }
    }
}
