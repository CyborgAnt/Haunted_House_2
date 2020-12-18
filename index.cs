/* Anthony Bonner
    11/24/2020
    1st Commit
    */

using System;
using System.Text;
using static System.Console;
using HouseFirst;

namespace FirstFloor
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Mystery At The Adams Manor, a Choose-Your-Own-Adventure Story!");
            Console.WriteLine("\nYou play as an Investigator, checking out the Adams Manor, site of strange events and stranger sights and sounds.");
            Console.WriteLine("You come armed with a Gun and a Flaslight.\n");

            Console.WriteLine("What will you find at the Adams Manor? It all depends on your choices!");
            Console.WriteLine("Press 'Enter' to Continue.");
            Console.ReadLine();         // waits on the user to press Enter

            Console.Clear();            // clears the console screen
            WriteLine("You begin your adventure by parking your car on the street and walking up to the porch of the house.\nYou grab the handle of the front door, pull it open, and step inside....");
            
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            FrontHouse.entryway();

        }
    }
}