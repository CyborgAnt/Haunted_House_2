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
            WriteLine("Enter '1' to check the Left Door\nEnter '2' to check the Right Door\nEnter '3' to choose the Hall\nEnter '0' to end the program");
            var choiceEntry = Int32.Parse(ReadLine());

            switch (choiceEntry)
            {
                // these are Test cases
                case 0:
                    WriteLine("You have exited the program.");
                    break;
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

        public static void study()
        {
            // left door
            WriteLine("You open the door to the left.");
            WriteLine("For an 'Abandoned' house, this room is in near-perfect shape. Press 'Enter' to continue.");
            Console.ReadLine();
            // Console.Clear();
            WriteLine("It is a Study, and a well-lit, well-furnished one. There is a very large window on the wall to your left. A long bench is in front of the window. Multiple comfortable-looking chairs dot the room, as well as small end tables. On the wall to your right, rows of tall book cases are nearly full with hardcover and paperback books, some journals, magazines, and encyclopedias.");
            WriteLine("There is no other door leading into, or out of, the room, other than the one you're stand ing at. Press 'Enter' to Continue.");
            Console.ReadLine();
            Console.Clear();

            WriteLine("What would you like to do?");
            var studyChoice = Int32.Parse(Console.ReadLine());

            /* switch cases; put in 'Decisions' file
               'Dictionary' on Bookcase 1; nothing in room-general
               */


        }

        public static void livingRoom()
        {
            // right door
            Console.Clear();
            WriteLine("You enter the Living Room.");
            WriteLine("The room is in a state of disrepair.\n You see a large grey couch, laying on it's side in the center of the room. A loveseat is also laying on its side, next to the couch.\nTo the left, there is a mantle piece against the far left wall. In front of the Mantle are the remains of what appears to be a coffee table - it looks like it was thrown against the mantle.");
            WriteLine("There are two, normal-sized windows on the wall across from the door, with some odds and ends on the floor, possibly from the coffee table.\nLooking at the Mantle: to its left, there is a set of stairs that lead up.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();

            WriteLine("What would you like to do?");
            var livingRoomChoice = Int32.Parse(ReadLine());

            /* switch-cases
                Mantle: some info on couple/family
                Closest Window: 'Movement'
                Farthest Window: 'Encounter'
                */

        }

        public static void bedroom()
        {
            Console.WriteLine("You enter a Bedroom.");
            Console.WriteLine("It's a large, nice bedroom, not suffering from the ramsacked appearance of most of the rest of the house.\n You see most of your 'typical' bedroom furniture: a large bed, a couple of night stands, a dresser, and a cabinet that has a lot of knick-knacks.\n");
            Console.WriteLine("There is a closet in a corner, and a door that opens onto a bathroom across from the closet.\nPress 'Enter' to continue.");
            
            Console.ReadLine();
            WriteLine("What would you like to do next?");

            /* switch-cases:
                bathroom - vision?
                closet, cabinet - nothing
                leave - back to Left Hall
                */


        }

        public static void hall()
        {
            Console.Clear();
            WriteLine("You start down the Hall.");
            WriteLine("The hall has a few spots where light bulbs would normally be set. However, only one bulb is in and lit, making the hall a bit gloomy.");
            WriteLine("You notice 3 separate doors on your left; they could be closets or storage spaces but all 3 doors are closed.");
            WriteLine("The hall ends at a 'T'-intersection with another hallway; where your hall ends, there is a door leading into another room.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();

            WriteLine("What would you like to do?");
            /* switch-cases:
                Door 1: Closet 1 - nothing
                Door 2: Closet 2 - Hand Encounter
                Door 3: Utility Closet - ?
                Door Ahead: Dining Room (BackHouse)
                New Hall - put in Back House
                */

        }

        public static void bathroom()
        {
            //bathroom also has an entry from the Left Branch of the New Hall
            WriteLine("You look into the bathroom");
            WriteLine("The bathroom is not overly large, but there's a large amount of damage that's been done to it. There is a large shower and bathtub, but the tub has been cracked. There is a sink and a medicine cabinet above it, but the sink has been ripped away from the wall, partially laying in/on the bath tub. Press 'Enter' to continue.");
            Console.ReadLine();
            WriteLine("As you continue to look around, you notice a few drops of blood on the floor, on the sink remnants, and on the walls. You don't see anything else of note.");
            // add branch to go back to New Hall or Bedroom

        }
        
    }
}