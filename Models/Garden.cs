using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTracker.Models
{
    public class Garden
        
    {
        public Guid Id { get; set; }
        public string Location { get; set; }
        public string NickName { get; set; }
        public List<Plant> Plants { get; set; }
        public DateTime DatePlanted { get; set; }

    }
}
