using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Core.Models.Production.Goats
{
    public class Customer
    {
        public long ID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
