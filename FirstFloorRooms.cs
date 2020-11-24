using System;
using System.Text;
using static System.Console;

namespace HouseFirst
{
    public class FrontHouse
    {
        public static void entryway()
        {
            
            WriteLine("The entryway is a small, square room. There was a coat rack in the far left corner, a couple of generic art pictures hung on the wall, and not else to the room. The room itself was fairly dark; sunlight, coming in from windows in the front door, was the only source of light in the entry.");
            WriteLine("Directly ahead of you, a hall leads into the gloom. To your left, a thick, cherry-colored door stands, closed. To your right, another door stands, although this door is more of a generic color, and not nearly as thick.");
            WriteLine("Press 'Enter to continue.");

            Console.ReadLine();
            Console.Clear();

            WriteLine("You have a few choices. What would you like to do?");
            WriteLine("Enter '1' to check the Left Door\nEnter '2' to check the Right Door\Enter '3' to choose the Hall\Enter 'Q' or 'q' to end the program");
            var choiceEntry = ReadLine();

            switch (choiceEntry)
            {
                // these are Test cases
                case 1:
                    WriteLine("Left Door!");
                    break;
                case 2:
                    WriteLine("Right Door!");
                    break;
                case 3:
                    WriteLine("Hall!");
                    break;    

                default:
                    WriteLine("You have exited the program.");
                    break;
            }

        }
    }
}