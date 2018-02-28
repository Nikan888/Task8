using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Bug : IAnimalWorld
    {
        public string Name { get; set; }
        public int NumberOfLimbs { get; set; }

        public Bug()
        {
            Name = "Bug";
            NumberOfLimbs = 6;
        }

        public void Voice()
        {
            Console.WriteLine("Buzz");
        }
    }
}
