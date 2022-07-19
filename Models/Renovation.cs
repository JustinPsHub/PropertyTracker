using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTracker.Models
{
    public class Renovation : IRenovate
    {
        [Key]
        public Guid Id { get; set; } = new Guid();
        
        [ForeignKey("Building")]
        public Guid BuildingId { get; set; }
        public string? Category { get; set; }
        public string? Purpose { get; set; }
        public string? ImprovementType { get; set; }
        public string? ImprovementDescription { get; set; }
        public double EstimatedCost { get; set; }
        public double ActualCost { get; set; }
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        public bool Contractor { get; set; }
        
       
      //  [ForeignKey("People")]
        public List<Person>? Renovators { get; set; }
        [ForeignKey("Property")]
        public Guid PropertyId { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }

        public double GetRenovationCost()
        {
            return ActualCost;

        }


    }

  


}
