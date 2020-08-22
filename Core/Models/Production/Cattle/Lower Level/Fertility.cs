using System;

namespace AgrixemAPI.Core.Models.Production.Cattle
{
    /// <summary>
    /// This class shows how fertile each animal. it refers to a single cow as a parent.
    /// </summary>
    /// <remarks>The age of first service and age  of first calving can be calculated from DOB and DOFAS , DOFC respectively.
    /// Alive Tell us if the offspring born alive or dead.</remarks>
    public class Fertility
    {
        public long ID { get; set; }
        public long CattleID { get; set; }
        public char Alive { get; set; }
        public DateTime? DateOfCalving { get; set; }
        public DateTime? DateofExpecting { get; set; }
        public DateTime? DateOfHeating { get; set; }
        public int? ConceptionNumber { get; set; }
        public int? NumberOfCalves { get; set; }
        public string Remarks { get; set; }

    }
}
