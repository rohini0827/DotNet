using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeFestEventHandling
{
    public class CollegeFestEventArgs : EventArgs
    {
        public int Visitors { get; }

        public CollegeFestEventArgs(int visitors)
        {
            Visitors = visitors;
        }
    }
}
