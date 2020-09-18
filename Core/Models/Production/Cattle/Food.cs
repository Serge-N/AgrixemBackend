using System;

namespace AgrixemAPI.Core.Models.Production.Cattle
{
    /// <summary>
    /// This class informs us what each cow will eat for a specified period of time.
    /// </summary>
    public class Food
    {
        public long ID { get; set; }
        public long CattleID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }
        public string FeedType { get; set; }
    }
}
