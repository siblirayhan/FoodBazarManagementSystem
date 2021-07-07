using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBazarManagementSystem.Models
{
    public class CustomerFeedback
    {
        public int id { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public String message { get; set; }
    }
}
