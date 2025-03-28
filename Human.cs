using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Human : Creature
    {
        public String Address;

        public void Think()
        {
            Console.WriteLine("human is thinking");
        }
    }
}
