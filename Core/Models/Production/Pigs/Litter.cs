using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Pig
{
    /// <summary>
    /// This class holds data for individual pigs at birth. It Refers pig as an offspring and not the Parent
    /// </summary>
    /// <remarks>It is important to record the individual birth properties of each litter.</remarks>
    public class Litter
    {
        public long PigID { get; set; }
        public Pig Pig { get; set; }
        public DateTime DateOfBith { get; set; }
        public int BirthWeight { get; set; }
        public DateTime? DateOfWeaning { get; set; }
        public int? WeaningWeight { get; set; }
    }

}
