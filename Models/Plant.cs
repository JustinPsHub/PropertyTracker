using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTracker.Models
{
    public class Plant     {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }

        public DateTime DatePlanted { get; set; }

        public double GetCost()
        {
            return Price * Quantity;
        }

        public int GetDaysSincePlanted()
        {
            return (int)(DateTime.Now - DatePlanted).TotalDays;
        }


    }
}
