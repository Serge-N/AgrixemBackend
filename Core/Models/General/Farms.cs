using System;

namespace AgrixemAPI.Core.Models.General
{/// <summary>
 /// All Farms that we oen.
 /// </summary>
 /// <remarks>Initial Cost allows nulls because inheritated farms are not purchase!
 /// All other classes depend on this, as such because of Multiple relationships 
 /// that will exist among various projects, no direct relationship we be configured here.
 /// </remarks>
    public class Farms
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int? InitialCost { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public string Owner { get; set; }
        public DateTime DoP { get; set; }
    }
}
