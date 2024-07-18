using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.interface_Ex2
{
    internal class SeriesByThree : Iseries
    {
        public int current
        {
            get;
            set;
        }

        public void GetNext()
        {
            current += 3;
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
