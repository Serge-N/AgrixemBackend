using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models
{
    /// <summary>
    /// This class shows us information related to illness of chickens, it is to recorded each time an illness cures.
    /// </summary>
    /// <remarks>Only recorded if an illness is detect, chickens are very senstive.</remarks>
    public class Diseases
    {
        public long ID { get; set; }
        public long BatchNumber { get; set; }
        public DateTime DayOfIllness { get; set; }
        public string Cause { get; set; }
        public string Treatment { get; set; }
        public int Deaths { get; set; }
    }
}
