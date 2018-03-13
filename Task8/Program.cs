using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Group<IAnimalWorld> mammals = new Group<IAnimalWorld>("MAMMALS");
            Group<IAnimalWorld> birds = new Group<IAnimalWorld>("BIRDS");
            Group<IAnimalWorld> insects = new Group<IAnimalWorld>("INSECTS");
            mammals.AddItem(new Dog());
            mammals.AddItem(new Whale());
            birds.AddItem(new Crow());
            birds.AddItem(new Eagle());
            insects.AddItem(new Bug());
            insects.AddItem(new Spider());

            Info(mammals);
            Info(birds);
            Info(insects);

            Console.ReadKey();
        }

        static void Info(Group<IAnimalWorld> group)
        {
            Console.WriteLine(group.GroupOfAnimals);
            Console.WriteLine("------------------------------------------");
            foreach (var animal in group.GetAll())
            {
                Console.WriteLine("Name: " + animal.Name);
                Console.WriteLine("Number of limbs: " + animal.NumberOfLimbs);
                animal.Voice();
                Console.WriteLine("------------------------------------------");
            }
            Console.WriteLine("/////////////////////////////////////////////////////////");
        }
    }
}
