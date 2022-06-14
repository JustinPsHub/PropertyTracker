using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTracker.Models
{
    public class House : Building, IRenovate
    {
        public enum Floors
        {
            Basement,
            FirstFloor,
            SecondFloor
        }   
        
        public Guid BathroomId { get; set; }
        public string BathroomName { get; set; }
        public Floors BathroomFloor { get; set; }

    }

}
