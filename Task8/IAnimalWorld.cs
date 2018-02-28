using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    interface IAnimalWorld
    {
        string Name { get; set; }
        int NumberOfLimbs { get; set; }
        void Voice();
    }
}
