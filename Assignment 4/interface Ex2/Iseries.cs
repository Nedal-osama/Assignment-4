using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.interface_Ex2
{
    internal interface Iseries
    {
        int current { get; set;}
        void GetNext();
        void Reset();

    }
}
