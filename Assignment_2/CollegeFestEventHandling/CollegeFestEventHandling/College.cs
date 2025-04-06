using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeFestEventHandling
{
    public class College
    {
        // Declare event
        public event EventHandler<CollegeFestEventArgs> CollegeFest;

        public void OrganizeFest(int visitors)
        {
            if (CollegeFest != null)
            {
                CollegeFest(this, new CollegeFestEventArgs(visitors));
            }
        }
    }
}
