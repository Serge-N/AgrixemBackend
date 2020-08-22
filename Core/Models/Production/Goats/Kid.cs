using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Goats
{
    /// <summary>
    /// This tells us information about the Goat as a kid
    /// </summary>
    /// <remarks>If Purchased the Date of birth is set due the age assumed.</remarks>
    public class Kid
    {
        public long GoatID { get; set; }
        public Goat Goats { get; set; }
        public DateTime DateOfbirth { get; set; }
        public int BirthWeight { get; set; }
        public DateTime? DateOfWeaning { get; set; }
        public int? WeaningWeight { get; set; }
        public string Abnomalies { get; set; }
    }
}
