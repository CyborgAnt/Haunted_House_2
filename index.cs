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
            Console.WriteLine("Welcome to The Dark House, a Choose-Your-Own-Adventure Story!");
            Console.WriteLine("\nYou are an Investigator, sent to check out the old Adams Manor, nicknamed 'The Dark House'. There have been reports of strange lights and noises at the House, plus sightings that might not be... human.");
            Console.WriteLine("You are armed with a Gun and a Flashlight.");

            Console.WriteLine("What will you find in the Dark House? It all depends on your choices!");
            Console.WriteLine("Press 'Enter' to Continue.");
            Console.ReadLine();         // waits on the user to press Enter

            Console.Clear();            // clears the console screen
            WriteLine("You start your adventure by walking up to the porch of the house.\nYou grab the handle of the front door, pull it open, and step into the entryway....");
            
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            FrontHouse.entryway();

        }
    }
}