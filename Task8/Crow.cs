using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Crow : IAnimalWorld, IFlyable
    {
        public string Name { get; set; }
        public int NumberOfLimbs { get; set; }

        public Crow()
        {
            Name = "Crow";
            NumberOfLimbs = 4;
        }

        public void Voice()
        {
            Console.WriteLine("Cah");
        }

        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}
