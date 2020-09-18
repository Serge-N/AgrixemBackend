using System;

namespace AgrixemAPI.Core.Models.Production.Goats
{
    /// <summary>
    /// This tells us information about the Goat as a kid
    /// </summary>
    /// <remarks>If Purchased the Date of birth is set due the age assumed.</remarks>
    public class Kid
    {
        public long ID { get; set; }
        public long GoatID { get; set; }
        public DateTime BirthDate { get; set; }
        public int BirthWeight { get; set; }
        public int? ThirtyDayWeight { get; set; }
        public int? SixityDayWeight { get; set; }
        public int? NinetyDayWeight { get; set; }
        public DateTime? WeaningDate { get; set; }
        public int? WeaningWeight { get; set; }
        public string Abnomalies { get; set; }
    }
}
