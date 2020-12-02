using System;
using System.Text;
using static System.Console;

namespace HouseFirst
{
    public class FrontHouse
    {
        public static void entryway()
        {
            
            WriteLine("The entryway is a small, square room. \nThere is a coat rack in the far left corner and a couple of generic art pictures hung on the wall, but not else to the room.\nThe room itself was fairly dark; sunlight, coming in from windows in the front door, was the only source of light in the entry.");
            WriteLine("Directly ahead of you, a hall leads into the gloom.\nTo your left, a thick, cherry-colored door stands, closed.\nTo your right, another door stands, although this door is more of a generic color, and not nearly as thick.");
            WriteLine("Press 'Enter to continue.");
            Console.ReadLine();

            WriteLine("You have a few choices to make. What would you like to do?");
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
                    FrontHouse.hallway();
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
            WriteLine("It is a Study, and a well-lit, well-furnished one. There is a very large window on the wall to your left. \nA long bench is in front of the window. Multiple comfortable-looking chairs dot the room, as well as small tables in front of some of the chairs. \nOn the wall to your right, rows of tall book cases are nearly full with hardcover and paperback books, some journals, magazines, and encyclopedias.");
            WriteLine("There is no other door leading into, or out of, the room, other than the one you're standing at. Press 'Enter' to Continue.");
            Console.ReadLine();

            WriteLine("What would you like to do?");
            WriteLine("Enter '1' to check the Bookcases\nEnter '2' to check one of the tables\nEnter '3' to return to the Entry\nAnything else to Quit the program");
            var studyChoice = Int32.Parse(Console.ReadLine());

            switch (studyChoice)
            {
                case 1:
                    //bookcase search
                    ItemSearches.studyBookcases();
                    break;
                case 2:
                    WriteLine("You check the small tables. You find nothing of interest or value. Press 'Enter' to continue and return to the Study.");
                    Console.ReadLine();
                    study();
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
            WriteLine("There are two, normal-sized windows on the wall across from the door, with some odds and ends on the floor\nThere is a set of stairs that lead up, placed in the left corner of the room.");
            WriteLine("The room itself is in a state of disrepair.\n You see a large gray couch, laying on it's side, in the center of the room. A loveseat is also laying on its side, next to the couch. \nThere is a Mantle piece against the far left wall.\nIn front of the Mantle are the remains of what appears to be a coffee table - it looks like it was thrown against the Mantle. There is a large hole in the right wall but no indication of what made that hole.");
            
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();

            WriteLine("There are a few options - what would you like to do?");

            WriteLine("Enter '1' to examine the Mantle\nEnter '2' to look out the Closest Window\nEnter '3' to look out the Far Window\nEnter '4' to check the Couch\nEnter '5' to check the Loveseat\nEnter  Leave the Living Room\n'0' to Quit the program");
            var livingRoomChoice = Int32.Parse(Console.ReadLine());

            switch (livingRoomChoice)
            {
                case 1:
                    // Mantle - picture, info
                    WriteLine("You walk over to the Mantle, being careful to not trip over the remains of the Coffee Table. Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    WriteLine("There isn't anything special about the Mantle itself. \nOn top of the Mantle, you find a few bills and other random pieces of paper: 2 or 3 receipts, a menu, and some scribbed notes of no importance.\nYou, however, do see a canle holder; odd, because it appears to be fastened to the Mantle.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();

                    WriteLine("You grab hold of the candle holder... and it folds in half! As it folds, you hear a shifting of... wood? Stone? from elsewhere in the house. You definitely file that in the memory banks and continue on. ");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    livingRoom();
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
                case 6:
                    WriteLine("You return to the Entry.");
                    entryway();
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
                    bathroom();
                    break;
                case 2:
                    //Bedroom Closet - nothing
                    ItemSearches.nothing();
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

        public static void hallway()
        {
            Console.Clear();
            WriteLine("You start down the Hall.");
            WriteLine("The hall has a few spots where light bulbs would normally be set. However, only one bulb is in and lit, making the hall a bit gloomy.");
            WriteLine("You notice 3 separate doors on your left; they could be closets or storage spaces but all 3 doors are closed.");
            WriteLine("The hall ends at a 'T'-intersection with another hallway; where that hall ends, there is a door leading into another room.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();

            WriteLine("What would you like to do?");
            WriteLine("Enter '0' to Quit the program\nEnter '1' to check the nearest Door\nEnter '2' to check the Middle Door\nEnter '3' to check the Far Door\nEnter '4' to continue to the End of the Hall");            
            
            var hallChoice = Int32.Parse(Console.ReadLine());

            switch(hallChoice)
            {
                case 1:
                    Encounters.hallCloset2();
                    break;
                case 2:
                    ItemSearches.nothing();
                    break;
                case 3:
                    ItemSearches.nothing();         // change/update 
                    break;
                case 4:
                    Backhouse.tHall();
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
            WriteLine("Code to come!");
        }

        public static void masterBedroom()
        {
            WriteLine("Code to come!");
        }

        public static void diningRoom()
        {
            WriteLine("Code to come!");
        }

        public static void kitchen()
        {
            WriteLine("Code to come!");
        }
    }
}