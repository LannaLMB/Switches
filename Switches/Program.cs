using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switches
{
    class Program
    {
        static void Main(string[] args)
        {

            // run variable will control do while loop
            bool run = true;

            do
            {

                Console.WriteLine("Welcome to GC Swag Shop!");
                Console.WriteLine("Please Select an Option from the Menu: ");
                Console.WriteLine("1: Mugs and Drinkware");
                Console.WriteLine("2: T-Shirts");
                Console.WriteLine("3: Pens and Notebooks");
                Console.WriteLine("4: Exit");


                int input;
                input = int.Parse(Console.ReadLine());


                switch (input)
                {
                    case 1:
                        Console.WriteLine("You Selected Option 1!");
                        break;

                    case 2:
                        Console.WriteLine("You Selected Option 2!");
                        break;

                    case 3:
                        Console.WriteLine("You Selected Option 3!");
                        break;
                    case 4:
                        Console.WriteLine("Thanks For Stopping By!");
                        run = false;  // terminate do while loop
                        break;

                    default:
                        Console.WriteLine("You Selected an Invalid Option.");
                        break;
                }
            } while (run);
        }
    }
}
