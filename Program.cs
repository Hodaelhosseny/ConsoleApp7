namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Instructor instructor = new Instructor();

            

            Marker marker = new Marker();
            Human human = new Human();


            Room room = new Room();
            room.InstructorEnter(instructor);
        }
    }
}
