using System;

namespace AgrixemAPI.Core.Models.Production.Goats
{
    /// <summary>
    /// This class deals with Goats as a whole - Deworming.... Dehorming... Vaccinations
    /// </summary>
    /// <remarks>It infroms us the preventive mesures we put in place.</remarks>
    public class GroupCure
    {
        public long ID { get; set; }
        public DateTime Date { get; set; }
        public long FarmID { get; set; }
        public string Type { get; set; }
        public string Reason { get; set; }
        public string Effect{ get; set; }
        public int? DrugAmount { get; set; }
        public string DrugUnits { get; set; }
        public int Cost { get; set; }
    }
}
