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

            WriteLine("You have a few choices. What would you like to do?");
            WriteLine("Enter '1' to check the Left Door\nEnter '2' to check the Right Door\nEnter '3' to choose the Hall\nEnter '0' to end the program");
            var choiceEntry = Int32.Parse(ReadLine());

            switch (choiceEntry)
            {
                case 0:
                    WriteLine("You have exited the program.");
                    break;
                case 1:
                    study();
                    break;
                case 2:
                    livingRoom();
                    break;
                case 3:
                    hall();
                    break;    
                default:
                    ItemSearches.nothing();     //will cut back on repetitive code
                    break;
            }

        }

        public static void study()
        {
            // left door
            WriteLine("You open the door to the left.");
            WriteLine("For an 'Abandoned' house, this room is in near-perfect shape. Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            WriteLine("It is a Study, and a well-lit, well-furnished one. There is a very large window on the wall to your left. A long bench is in front of the window. Multiple comfortable-looking chairs dot the room, as well as small tables in front of some of the chairs. On the wall to your right, rows of tall book cases are nearly full with hardcover and paperback books, some journals, magazines, and encyclopedias.");
            WriteLine("There is no other door leading into, or out of, the room, other than the one you're stand ing at. Press 'Enter' to Continue.");
            Console.ReadLine();

            WriteLine("What would you like to do?");
            var studyChoice = Int32.Parse(Console.ReadLine());

            WriteLine("Enter '1' to check the Bookcases\nEnter '2' to check one of the tables\nEnter '3' to return to the Entry\nAnything else to Quit the program");

            switch (studyChoice)
            {
                case 1:
                    //bookcase search
                    ItemSearches.studyBookcases();
                    break;
                case 2:
                    WriteLine("You check the small tables. You find nothing of interest or value. Press 'Enter' to continue and return to the Study.");
                    Console.ReadLine();
                    break;
                case 3:
                    // return to the Entry
                    entryway();
                    break;
                default:
                    WriteLine("You have exited the program.");
                    break;
            }

        }

        public static void livingRoom()
        {
            // right door
            Console.Clear();
            WriteLine("You open the door and enter the Living Room.");
            WriteLine("The room is in a state of disrepair.\n You see a large grey couch, laying on it's side in the center of the room. A loveseat is also laying on its side, next to the couch.\nTo the left, there is a mantle piece against the far left wall. In front of the Mantle are the remains of what appears to be a coffee table - it looks like it was thrown against the mantle.");
            WriteLine("There are two, normal-sized windows on the wall across from the door, with some odds and ends on the floor, possibly from the coffee table.\nLooking at the Mantle: to its left, there is a set of stairs that lead up.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();

            WriteLine("What would you like to do?");
            var livingRoomChoice = Int32.Parse(ReadLine());

            WriteLine("Enter '1' to check the Mantle\nEnter '2' to look out the Closest Window\nEnter '3' to look out the Far Window\nEnter '4' to check the Couch\nEnter '5' to check the Loveseat\nEnter Any Other Character to Quit the program");

            switch (livingRoomChoice)
            {
                case 1:
                    // Mantle - picture, info
                    break;
                case 2:
                    // Window - near
                    Console.Clear();
                    WriteLine("You head over to the nearest window and take a look out.");
                    WriteLine("It's dusk, not quite total darkness. There is a line of trees a few dozen feet away. You look deep - something moved in the trees! Press 'Enter' to continue.");

                    Console.ReadLine();
                    // Console.Clear();
                    WriteLine("You try to focus on the movement but can't quite make out what it was... other than it wasn't small. Slightly disturbed, you turn your attention back to the Living Room. Press 'Enter' to continue.");

                    Console.ReadLine();
                    Console.Clear();
                    livingRoom();                  
                    break;
                case 3:
                    // Window - far
                    Encounters.window2();
                    break;
                case 4:
                    ItemSearches.couch();
                    break;            
                case 5:
                    ItemSearches.nothing();
                    break;                
                default:
                    WriteLine("You have exited the program.");
                    break;
            }
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
            WriteLine("Enter '1' to check the Bathroom\nEnter '2' to check the Closet\nEnter '3' to check the Cabinet\nEnter '4' to Leave the bedroom\nEnter Anythng else to Quit the program.");
            Console.ReadLine();

            var bedroomChoice = Int32.Parse(Console.ReadLine());

            switch (bedroomChoice)
            {
                case 1:
                    //Bathroom

                    break;
                case 2:
                    //Bedroom Closet - nothing

                    break;
                case 3:
                    //Cabinet - ?

                    break;

                case 4:
                    WriteLine("You leave the bedroom. Press 'Enter' to continue.");
                    Console.ReadLine();            
                    break;
                default:
                    WriteLine("You have exited the program.");
                    break; 
            }
        }

        public static void hall()
        {
            Console.Clear();
            WriteLine("You start down the Hall.");
            WriteLine("The hall has a few spots where light bulbs would normally be set. However, only one bulb is in and lit, making the hall a bit gloomy.");
            WriteLine("You notice 3 separate doors on your left; they could be closets or storage spaces but all 3 doors are closed.");
            WriteLine("The hall ends at a 'T'-intersection with another hallway; where that hall ends, there is a door leading into another room.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();

            WriteLine("What would you like to do?");
            /* switch-cases:
                Door 1: Closet 1 - nothing
                Door 2: Closet 2 - Hand Encounter
                Door 3: Utility Closet - ?
                Door Ahead: Dining Room (BackHouse)
                New Hall - put in Back House
                */
            var hallChoice = Int32.Parse(Console.ReadLine());

            switch (hallChoice)
            {
                case 1:
                    Encounters.hand();
                    break;


                default:
                    WriteLine("You have exited the program.");
                    break;
            }

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

    class Backhouse
    {
        public static void tHall()
        {

        }

        public static void masterBedroom()
        {

        }

        public static void diningRoom()
        {

        }

        public static void kitchen()
        {

        }
    }
}