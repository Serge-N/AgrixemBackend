using System;

namespace AgrixemAPI.Core.Models.Production.Cattle
{
    /// <summary>
    /// This class is used for individual Cattle Treatment
    /// </summary>
    /// <remarks>It is important to remember that not all Cattle will be sick at the same time, therefore the need for grouping is not essential.</remarks>
    public class Treatment
    {
        public long ID { get; set; }
        public long CattleID { get; set; }
        public DateTime Date { get; set; }
        public string Disease { get; set; }
        public string Cure { get; set; }
        public string DrugName { get; set; }
        public int? DrugAmount { get; set; }
        public string DrugUnits { get; set; }
        public string Remarks { get; set; }
    }
}
