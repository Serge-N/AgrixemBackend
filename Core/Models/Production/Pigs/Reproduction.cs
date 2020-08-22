using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Pig
{
    /// <summary>
    /// This class stores data for collective number for a single pig. It refers to the pig as a parent not an offspring
    /// </summary>
    /// <remarks>Each pig gives multiple births in its lifetime, however each record is unque</remarks>
    public class Reproduction
    {

        public long PigID { get; set; }
        public Pig Pig { get; set; }
        public DateTime DateOfFirstOestrus { get; set; }

    }
}
