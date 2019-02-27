using System;

namespace Turtles
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Prints "I like turtles." 1000 times.
            string turtles = "I like turtles.";
            int counter = 0;
            while (counter < 1001)
            {
                Console.WriteLine(turtles);
                counter++;
            }

            Console.ReadLine();
        }
              
    }
}
