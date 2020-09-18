using System;

namespace AgrixemAPI.Core.Models.Production.Cattle
{
    /// <summary>
    /// This class monitors the growth of the a cow from birth to sale.
    /// </summary>
    /// <remarks>The Mode refers to sale as whole or Carcus.</remarks>
    public class Growth
    {
        public long CattleID { get; set; }
        public long CattleFK { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfSale { get; set; }
        public DateTime? DateOfWeaning { get; set; }
        public DateTime? DateOfPurchase { get; set; }
        public int? BirthWeight { get; set; }
        public int? SalePrice { get; set; }
        public int? SaleWeight { get; set; }
        public int? WeaningWeight { get; set; }
        public int? PurchaseValue { get; set; }
        public string Buyer { get; set; }
        public string Mode { get; set; }
        public string Seller { get; set; }

    }
}
