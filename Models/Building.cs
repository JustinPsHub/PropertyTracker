using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTracker.Models
{
    public class Building : IRenovate

    {
        public Guid Id { get; set; }
        public int Levels { get; set; }
        public int WindowCount { get; set; }
        public int DoorCount { get; set; }
        public string? Purpose { get; set; }
        public string? EstimatedCost { get ; set ; }
        public DateTime StartDate { get ; set; }
        public DateTime EndDate { get ; set ; }
        public byte[]? BuildingImage { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
    

}
