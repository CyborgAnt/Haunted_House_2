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
            Console.WriteLine("Welcome to 'Mystery At The Manor', a Choose-Your-Own-Adventure Story!");
            Console.WriteLine("The owners of the Manor, Richard and Rosalyn Adams, have been missing for days. They are the latest in a string of disappearances and strange reports that involve the Manor.\nYou are a Private Investigator, hired to find out where the Adams couple is... and what is going on at their manor.");

            Console.WriteLine("Press 'Enter' to Continue.");
            Console.ReadLine();
            Console.WriteLine("You are equipped with a phone, backpack, and a gun.\nWill you find the Adams couple?\nWill you you solve the mysteries of the Adams Manor?\n\nIt all depends on the choices you make!");
            Console.WriteLine("Press 'Enter' to Continue.");
            Console.ReadLine();         // waits on the user to press Enter

            Console.Clear();            // clears the console screen
            WriteLine("The adventure begins with you parking your car on the street and walking up to the porch of the house.\nThere is a large front yard; there is a grove of trees to the right.\nYou grab the handle of the front door, pull it open, and step inside....");
            
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            FrontHouse.entryway();

        }
    }
}