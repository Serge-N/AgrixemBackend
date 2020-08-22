using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Pig
{
    /// <summary>
    /// This provides the number of and Dates each pig has given birth.
    /// </summary>
    /// <remarks>It contains many records of reproduction</remarks>

    public class Farrowing
    {
        public long ID {get; set;}
        public long ReproductionID { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfLittersBornAlive { get; set; }
        public int NumberOfLittersBornDead { get; set; }
        public double AverageBirthWeight { get; set; }
    }
}
