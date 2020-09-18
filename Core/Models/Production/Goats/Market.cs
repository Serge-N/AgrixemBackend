namespace AgrixemAPI.Core.Models.Production.Goats
{
    /// <summary>
    /// This class shows us the individual Goat sales
    /// </summary>
    /// <remarks>The GoatID is unque in this case and Non of the fields is to be null.</remarks>
    public class Market
    {
        public long ID { get; set; }
        public int FarmID { get; set; }
        public long GoatID { get; set; }
        public long CustomerID { get; set; }
        public int SalePrice { get; set; }
        public int SaleWeight { get; set; }
        public string Mode { get; set; }
        public string Comments { get; set; }
    }
}
