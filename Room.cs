using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Room
    {
        Instructor Instructor;
        Students[] students = new Students[10];
        Wall[] walls = new Wall[4];
         public Room()
        {
            for (int i =0; i<walls.Length; i++)
            {
                walls[i] = new Wall();
            }
        }


        public void InstructorEnter( Instructor instructor)
        {
            this.Instructor = instructor;
        }

        public void InstructorLeave()
        {
            Instructor = null;
        }

    }
}
