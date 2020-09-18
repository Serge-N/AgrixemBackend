using System;

namespace AgrixemAPI.Core.Models.Production.Goats
{
    /// <summary>
    /// This class tells us of Goats that ill.
    /// </summary>
    /// <remarks>Dipping is treated as part of treatment. Type can be Deworming, Hoof Treatment, or any other treatment</remarks>
    public class Cure
    {
        public long ID { get; set; }
        public long GoatID { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime StoppingDate { get; set; }
        public string Type { get; set; }
        public string Reason { get; set; }
        public string Effect { get; set; }
        public string DrugName { get; set; }
        public int? Quantity { get; set; }
        public string Units { get; set; }
        public char Recovered { get; set; }

    }
}
