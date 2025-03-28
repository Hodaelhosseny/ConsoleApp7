using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Creature
    {
        public int Length;
        public int weight;
        public int Age;

        public void Move()
        {
            Console.WriteLine(" creature is moving");
        }
        public void Eat()
        {
            Console.WriteLine(" creature is Eating");
        }
    }
}
