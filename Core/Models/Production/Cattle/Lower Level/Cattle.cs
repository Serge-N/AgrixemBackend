namespace AgrixemAPI.Core.Models.Production.Cattle
{
    /// <summary>
    /// This class shows us all the cattle that we have.
    /// </summary>
    /// <remarks>
    /// The farmID helps us call cattle that belong to single farm.
    /// At the end of it all we should be able to perform the following head records. 
    /// - Number of Cattle.
    /// - Head Fertilty
    /// - Family Tree.
    /// - Vaccination Schedule
    /// - Most frequent disease.
    /// - Deworming Schedule.
    /// - Cattle Growth.
    /// - Average Cattle Sales
    /// - Customer Mode preferences
    /// - Plus many more.
    /// </remarks>
    public class Cattle
    {
        public long ID { get; set; }
        public long TagID { get; set; }
        public int FarmID { get; set; }
        public int CurrentValue { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Status { get; set; }

    }
}
