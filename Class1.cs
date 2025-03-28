using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Manager
    {
        private static Manager ManagerInstance ;
        private Manager()
        {
            Console.WriteLine("one instance created");

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public static Manager GetManagerInstance()
        {
            if(GetManagerInstance == null)
            {
                ManagerInstance = new Manager();
            }
            return ManagerInstance;
        }
    }
}
