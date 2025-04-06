using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeFestEventHandling
{
    public class Caterer
    {
        private const int costPerPlate = 200;

        public void OnCollegeFest(object sender, CollegeFestEventArgs e)
        {
            int cateringCost = e.Visitors * costPerPlate;
            Console.WriteLine($"Catering Cost: Rs. {cateringCost}");
        }

        public int GetCateringCost(int visitors)
        {
            return visitors * costPerPlate;
        }
    }
}
