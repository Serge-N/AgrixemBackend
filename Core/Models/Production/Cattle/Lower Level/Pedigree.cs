using AgrixemAPI.Core.Models.Production.Cattle;

namespace AgrixemAPI.Core.Models
{
    /// <summary>
    /// This class determine the parents of each cow.
    /// </summary>
    /// <remarks>It is unque to each cattle it supports null to account cattle purchased.</remarks>
    public class Pedigree
    {
        public long CattleID { get; set; }
        public long CattleFK { get; set; }
        public long ? MotherID { get; set; }
        public long ? FatherID { get; set; }
       
    }
}
