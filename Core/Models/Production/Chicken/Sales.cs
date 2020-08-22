using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Chicken
{
    /// <summary>
    /// This class shows us information about the customer
    /// </summary>
    /// <remarks>Mode as infroms us the if the batch was sold as dead meat
    /// Payment Mode tells us if it was cash or credit, if credit then add to creditors list in financial records.</remarks>
    public class Sales
    {
        public long BatchNumber { get; set; }
        public Chicks Chicks { get; set; }
        public DateTime DateOfSale { get; set; }
        public int UnitSalePrice { get; set; }
        public int Number { get; set; }
        public int Bonus { get; set; }
        public string Mode { get; set; }
        public string Customer { get; set; }
        public string PaymentMode { get; set; }
    }
}
