using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            Person person0 = new Person();
            Person person1 = new Person();
            person.Name = Console.ReadLine();
            person0.Name = Console.ReadLine();
            person1.Name = Console.ReadLine();

            Console.WriteLine("\n" + person.Name + "\n" + person0.Name + "\n" + person1.Name + "\n" + person1.Count);

        }
    }
    internal class Person
    {
        private string name;
        private static int count;
        public Person()
        {
            count = count + 1;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Count { get { return count; } }


    }
}