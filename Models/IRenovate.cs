using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTracker.Models
{
    public interface IRenovate
    {

        public decimal GetRenovationCost(decimal cost)
        {
            return cost;
        }


    }
}
