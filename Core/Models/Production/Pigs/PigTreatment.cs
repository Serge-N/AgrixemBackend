using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Pig
{
    /// <summary>
    /// This is a record for illnesses for each individual pig.
    /// </summary>
    /// <remarks>Not that a pig might not get sick once. Therefore pig ID is not unque.</remarks>
    public class PigTreatment
    {
        public long ID { get; set; }
        public long PigID { get; set; }
        public DateTime Date { get; set; }
        public string Symptoms { get; set; }
        public string Medication { get; set; }
        public char Recovered { get; set; }
    }
}
