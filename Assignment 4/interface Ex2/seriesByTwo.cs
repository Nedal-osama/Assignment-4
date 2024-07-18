using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.interface_Ex2
{
    internal class seriesByTwo : Iseries
    { 
        public int current
        {
            get { return current; }
            set { current = value; }
        }

        public void GetNext()
        {
            current += 2;
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
