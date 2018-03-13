using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Group<T> where T : class
    {
        List<T> listOfAnimals;
        //T[] listOfAnimals;
             
        string groupOfAnimals;
        //int i = 0;

        public string GroupOfAnimals { get => groupOfAnimals; set => groupOfAnimals = value; }

        public Group(string type)
        {
            listOfAnimals = new List<T>();
            groupOfAnimals = type;
        }

        public List<T> GetAll()
        {
            return listOfAnimals;
        }
        
        public void AddItem(T item)
        {
            listOfAnimals.Add(item);
        }

        public void RemoveItem(int index)
        {
            if (index > listOfAnimals.Count - 1)
                Console.WriteLine("Index out of range");
            else
                listOfAnimals.RemoveAt(index);
        }

        public void RemoveItem(T item)
        {
            listOfAnimals.Remove(item);
        }

        public T GetItem(int index)
        {
            T a = null;
            if (index > listOfAnimals.Count - 1)
                Console.WriteLine("Index out of range");
            else
                a = listOfAnimals[index];
            return a;
        }
    }
}
