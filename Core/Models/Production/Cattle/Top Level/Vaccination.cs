using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Cattle
{
    /// <summary>
    /// This Handles the Cattle Vaccination. It is a group activity.
    /// </summary>
    /// <remarks>Dipping is part of treatment.</remarks>
    public class Vaccination
    {
        public long ID { get; set; }
        public int FarmID { get; set; }
        public DateTime Date { get; set; }
        public string Purpose { get; set; }
        public string Detail { get; set; }
        public string DrugName { get; set; }
        public int ? DrugQuality { get; set; }
        public string DrugUnits { get; set; }
        public string Remark { get; set; }
        public string Done { get; set; }
    }
}
