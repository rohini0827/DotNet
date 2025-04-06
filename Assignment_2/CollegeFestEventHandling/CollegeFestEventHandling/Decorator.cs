using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeFestEventHandling
{
    public class Decorator
    {
        private const int baseDecorationCost = 10000;
        private const int costPerStudent = 10;

        public void OnCollegeFest(object sender, CollegeFestEventArgs e)
        {
            int decorationCost = baseDecorationCost + (e.Visitors * costPerStudent);
            Console.WriteLine($"Decoration Cost: Rs. {decorationCost}");
        }

        public int GetDecorationCost(int visitors)
        {
            return baseDecorationCost + (visitors * costPerStudent);
        }
    }
}
