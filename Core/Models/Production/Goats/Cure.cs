using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Goats
{
    /// <summary>
    /// This class tells us of Goats that ill.
    /// </summary>
    /// <remarks>Dipping is treated as part of treatment.</remarks>
    public class Cure
    {
        public long ID { get; set; }
        public long GoatID { get; set; }
        public DateTime DateOfIllness { get; set; }
        public string Type { get; set; }
        public string Reason { get; set; }
        public string Effect { get; set; }
        public string DrugName { get; set; }
        public int? DrugAmount { get; set; }
        public string DrugUnits { get; set; }
        public int? Weight { get; set; }

    }
}
