using System;
using System.Text;
using static System.Console;

namespace FirstFloor
{
    public class FrontHouse
    {
        public static void entryway()
        {
            
            WriteLine("You enter in a small entryway, a square, nearly empty room. \nThere is a coat rack in the far left corner and a couple of generic art pictures hung on the wall, but not else to the room.\nThe room itself was fairly dark; evening sunlight, coming in from windows in the front door, is the only source of light in the entry.");
            WriteLine("Directly ahead of you, a hall leads into the gloom.\nTo your left, a thick, cherry-colored door stands, closed.\nTo your right, another door stands, although this door is more 'generic', and not nearly as thick.");
            WriteLine("Press 'Enter to continue.");
            Console.ReadLine();
            Console.Clear();
            
            entrywayChoice();
        }
        public static void entrywayChoice()
        {
            WriteLine("|                                               |");
            WriteLine("|                       ------------------------|");
            WriteLine("|                    |  |                       |");
            WriteLine("|                    |  |                       |");
            WriteLine("|--------------------|  |                       |");
            WriteLine("|                  --|  |---                    |");
            WriteLine("|                  |      |                     |");
            WriteLine("|                 \\ Entry \\                     |");
            WriteLine("|------------------|--\\---|-----------------------|");
            
                        
            WriteLine("You have a few choices to make. What would you like to do?");
            WriteLine("Enter '1' to check the Left Door\nEnter '2' to check the Right Door\nEnter '3' to choose the Hall\n'4' to Leave the House\nEnter '0' to end the program");
            var choiceEntry = Int32.Parse(ReadLine());

            switch (choiceEntry)
            {
                case 0:
                    WriteLine("You have exited the program.");
                    System.Environment.Exit(0);
                    break;
                case 4:
                    WriteLine("You decide to put off this investigation for another day.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
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
            WriteLine("You open the door to the left and see a Study.");
            WriteLine("For an 'Abandoned' house, this room is in near-perfect shape. Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            WriteLine("It is a well-lit, well-furnished room.\nThere is a very large window on the wall to your left. A long bench is in front of the window.\nMultiple comfortable-looking chairs dot the room, as well as small tables in front of some of the chairs. \nOn the wall to your right, rows of tall book cases are nearly full with hardcover and paperback books, some journals, magazines, and encyclopedias.");
            WriteLine("There is no other door leading into, or out of, the room, other than the one you're standing at. Press 'Enter' to Continue.");
            Console.ReadLine();
            studyChoose();
        }    
        public static void studyChoose()
        {
            WriteLine("|                                               |");
            WriteLine("|                                               |");
            WriteLine("|--------------------------                     |");
            WriteLine("|   Bookcases              |                    |");
            WriteLine("|                          |                    |");
            WriteLine("|          STUDY           |--|  |--|           |");
            WriteLine("|                         \\  Entry \\          |");
            WriteLine("|          window          |        |           |");
            WriteLine("|-----------------------------------------------|");
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
                    studyChoose();
                    break;
                case 3:
                    // return to the Entry
                    entryway();
                    break;
                default:
                    WriteLine("You have exited the program.");
                    System.Environment.Exit(0);
                    break;
            }

        }

        public static void livingRoom()
        {
            // right door
            Console.Clear();
            WriteLine("You open the door and enter the Living Room.");
            WriteLine("There are two, normal-sized windows on the wall across from the door, with some odds and ends on the floor.\nThere is a set of stairs that lead up, in the left corner of the room.");
            WriteLine("The room itself is in a state of slight disrepair.\n You see a large gray couch, laying on it's side, in the center of the room. A loveseat is also laying on its side, next to the couch. \nThere is a Mantle piece against the far left wall.\nIn front of the Mantle are the remains of what appears to be a coffee table - it looks like it was thrown against the Mantle. There is a large hole in the right wall but no indication of what made that hole.");
            
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            lvrChoose();
        }
        public static void lvrChoose()
        {
            WriteLine("|                                               |");
            WriteLine("|                ------------------------------ |");
            WriteLine("|             |  | Stairs |                     |");
            WriteLine("|             |  | --------               Window|");
            WriteLine("|             |  |       Living                 |");
            WriteLine("|-------------|  |        Room                  |");
            WriteLine("|             |  |---                           |");
            WriteLine("|           |       |                     Window|");
            WriteLine("|          \\ Entry \\                          |");
            WriteLine("|-----------|--\\---|---------------------------|");
            WriteLine("What would you like to do, next?");

            WriteLine("Enter '1' to examine the Mantle\nEnter '2' to look out the Closest Window\nEnter '3' to look out the Far Window\nEnter '4' to check the Couch\nEnter '5' to check the Loveseat\nEnter '6' to Leave the Living Room\nEnter '7' to check out the Stairs\n Enter '0' to Quit the program");
            var livingRoomChoice = Int32.Parse(Console.ReadLine());

            switch (livingRoomChoice)
            {
                case 1:
                    // Mantle - picture, info
                    WriteLine("You walk over to the Mantle, being careful to not trip over the remains of the Coffee Table. Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    WriteLine("There isn't anything special about the Mantle itself. \nOn top of the Mantle, you find a few bills and other random pieces of paper: 2 or 3 receipts, a menu, and some scribbed notes of no importance.\nYou, however, do see a candle holder; odd, because it appears to be fastened to the Mantle.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();

                    WriteLine("You grab hold of the candle holder... and it folds in half! As it folds, you hear a shifting of... wood? Stone? from elsewhere in the house. You definitely file that in the memory banks and continue on. ");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    lvrChoose();
                    break;
                case 2:
                    // Window - near
                    Console.Clear();
                    WriteLine("You head over to the nearest window and take a look out.");
                    WriteLine("It's dusk, not quite total darkness. There is a line of trees a few dozen feet away.\nYou look deep - something moved in the trees! Press 'Enter' to continue.");

                    Console.ReadLine();
                    // Console.Clear();
                    WriteLine("You try to focus on the movement but can't quite make out what it was... other than it wasn't small. Slightly disturbed, you turn your attention back to the Living Room. Press 'Enter' to continue.");

                    Console.ReadLine();
                    Console.Clear();
                    lvrChoose();                  
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
                    lvrChoose();
                    break;
                case 6:
                    WriteLine("You return to the Entry.");
                    entryway();
                    break;
                case 7:
                    WriteLine("You walk over to the stairs. There's nothing particularly special about them, so you head up them....");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    SecondFloorRooms.stairs();       // start of the 2nd floor
                    break;

                default:
                    WriteLine("You have exited the program.");
                    System.Environment.Exit(0);
                    break;
            }
        }

        public static void bedroom()
        {
            Console.WriteLine("You enter a Bedroom.");
            Console.WriteLine("It's a large, nice bedroom, not suffering from the ramsacked appearance of most of the rest of the house.\n You see most of your 'typical' bedroom furniture: a large bed, a couple of night stands, a dresser, and a cabinet that has a lot of knick-knacks.\n");
            Console.WriteLine("There is a closet in the far left corner, and a door that opens onto a bathroom across from the closet.\nPress 'Enter' to continue.");
            
            Console.ReadLine();
            bedroomChoose();
        }
        public static void bedroomChoose()
        {
            WriteLine("|--------\\--------------\\----|     ");
            WriteLine("|                   |          |     ");
            WriteLine("|                   | Bathroom |     ");
            WriteLine("|     Bedroom       \\         |     ");
            WriteLine("|                   |          |     ");
            WriteLine("|------------------------------|     ");
            WriteLine("|                              |     ");
            WriteLine("|                              |     ");
            WriteLine("|            STUDY             |     ");
            WriteLine("|------------------------------|     ");
            
            WriteLine("What would you like to do next?");

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
                    WriteLine("Other than the knick-knacks, the only thing you find of interest is a piece of paper, with the number '7521' written on it.\nYou decide to check the bathroom before leaving.");
                    bathroom();
                    break;

                case 4:
                    WriteLine("You leave the bedroom. Press 'Enter' to continue.");
                    Console.ReadLine();
                    Backhouse.tHall();        // check this branch            
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

            WriteLine("|       -------------\\---------");
            WriteLine("|                               ");
            WriteLine("|       -----------        -----");
            WriteLine("|       | Util.    \\       |    ");
            WriteLine("|       -----------        |    ");
            WriteLine("|       |         \\        |    ");
            WriteLine("|       | Closet2 |        |    ");
            WriteLine("|       -----------        |    ");
            WriteLine("|       |         \\  Hall  |    ");
            WriteLine("|       | Closet1 |        |    ");
            WriteLine("|       ----------|        |----|");
            WriteLine("|       |           Entry       |");
            
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
            WriteLine("|---------\\-------------\\----|     ");
            WriteLine("|                   |          |     ");
            WriteLine("|                   | Bathroom |     ");
            WriteLine("|     Bedroom       \\         |     ");
            WriteLine("|                   |          |     ");
            WriteLine("| -----------------------------|     ");
            WriteLine("|                              |     ");
            WriteLine("|                              |     ");
            WriteLine("|            STUDY             |     ");
            WriteLine("|------------------------------      ");
            WriteLine("The bathroom is not overly large, but there's a large amount of damage that's been done to it.\nThere is a large shower and bathtub, but the tub has been cracked.\nThere is a sink and a medicine cabinet above it, but the sink has been ripped away from the wall, partially laying in/on the bath tub. Press 'Enter' to continue.");
            Console.ReadLine();
            WriteLine("As you continue to look around, you notice a few drops of blood on the floor, on the sink remnants, and on the walls. You don't see anything else of note. You go to the Bedroom. Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            bedroom();
        }
        
    }

    class Backhouse
    {
        public static void tHall()
        {
            WriteLine("You continue down the main hall until you reach the T-intersection. Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            WriteLine("There are 3 main choices that you see:\n1. Straight ahead, there is a closed door.\n2. To your left, the hall continues a short distance until ending at a wall. On the left side of that hall branch, there are two doors: one opens onto what looks like a Bathroom, the other door was closed.\nOn the right side of that hall branch is another door, across from the closed door on the left.\n3. To your right, the hall ends at a door to the outside. On the left side, there is an opening that leads to what looks like a Kitchen.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            tHallChoose();
        }
        public static void tHallChoose()
        {
            WriteLine("|-------------------------------------------------------------------|");
            WriteLine("|                    |                        |                     |");
            WriteLine("|                    |                        |                     |");
            WriteLine("|                    |                        |                     |");
            WriteLine("|                    |                        |                     |");
            WriteLine("|                    |                        |                     |");
            WriteLine("|----------\\----------------------\\-------------------||------------\\");
            WriteLine("|---------\\---------------\\-----       -----------------------------|");
            WriteLine("|                     |         |      |                            |");
            WriteLine("|      Bedroom        |  Bath   |      |        Living Room         |");                 
            WriteLine("|                     |         |      |                            |");

            WriteLine("What do you do?");
            WriteLine("1. Take the Left Hall and check the Right Door\n2. Take the Left Hall and check the Left Door\n3. Take the Left Hall and check the Bathroom\n4. Check the Door Ahead\n5. Take the Right Hall and check the Left Door\n6. Check the door to the Outside\n7. Go back to the Entry");

            var tHallChoice = Int32.Parse(Console.ReadLine());

            switch (tHallChoice)
            {
                case 1:
                    // Left - Right Door
                    // Master Bedroom
                    WriteLine("You turn down the left branch of the new hallway.\nYou decide to see what's behind the door on the right. Press 'Enter' to continue.");
                    Console.ReadLine();
                    masterBedroom();
                    break;
                case 2:
                    // Left - Left Door
                    // Bedroom
                    FirstFloor.FrontHouse.bedroom();
                    break;
                case 3:
                    // Left - Bathroom
                    WriteLine("You decide to take the left hallway. You check the Bathroom.\nPress 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    FirstFloor.FrontHouse.bathroom();
                    break;
                case 4:
                    // Dining Room
                    diningRoom();
                    break;
                case 5:
                    // Right - Left Door
                    kitchen();
                    break;
                case 6:
                    // Outside
                    break;
                case 7:
                    // Back to the Entry
                    FrontHouse.entrywayChoice();
                    break;        
                default:
                    break;
            }        
        }

        public static void masterBedroom()
        {
            Console.Clear();
            WriteLine("You enter the Master Bedroom. This bedroom is massive.\nThere is a closet in the far left room, with the door open; you can't see everything that might be in it from where you're standing.\nIn the right corner, a door opens onto a private bathroom.\nTo the right of the door is a tall wardrobe, made of cherry wood; it's doors are closed. There is a faint odor coming from the wardrobe's direction.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();

            WriteLine("\nIn the center of the room is a canopied, King-sized bed, adorned with light blue sheets and a comforter.\nThere are also a few pieces of furniture - a couple of night stands, a dresser, and a small desk - that catch your eye but don't appear to have anything of importance or note on them.\nThere is a window on the left wall, near the Closet, and a larger window on the far wall, between the Closet and the Bathroom.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();

        }
        public static void masterbedroomChoose()
        {    
            WriteLine("|-------------------------------------------------------------------|");
            WriteLine("|               |    |                        |                     |");
            WriteLine("|     Master    |    |                        |                     |");
            WriteLine("|     Bedroom   -----|                        |                     |");
            WriteLine("|                    |                        |                     |");
            WriteLine("|                    |                        |                     |");
            WriteLine("|----------\\---------------------\\--------------------||---------\\");
            WriteLine("|---------\\---------------\\---       -----------------------------|");
            WriteLine("|                     |         |      |                            |");
            WriteLine("|      Bedroom        |         |      |                            |");                 
            WriteLine("|                     |         |      |                            |");
            WriteLine("What would you like to do?");
            WriteLine("1. Leave the Master Bedroom and go back to the T-intersection\n2. Check the Closet\n3. Check the Large Window\n4. Check the Bathroom\n5. Check the Wardrobe\n0. Quit the Program");

            var mbrChoice = Int32.Parse(Console.ReadLine());

            switch(mbrChoice)
            {
                case 1:
                    WriteLine("You decide to leave the Master Bedroom and head back to the hallway intersection.\n");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    tHallChoose();
                    break;
                case 2:
                    //closet
                    WriteLine("You walk over to the closet.\nThere are some jackets, coats, and other clothing odds and ends, hanging on the closet bar.\nOn a shelf above the clothes, there is a hat, some small boxes and a few small plastic containers, filled with knick-knacks. In front of one of these containers is a rectangular box.");
                    
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    WriteLine("You take a closer look at the box - it's a box of 20 bullets. Opening the box, you see that these are SILVER BULLETS.\n");
                    //var silverBullets = 20;       used in Final Battle
                    WriteLine("You take the box, although you're now wondering why someone would need a specific type of bullet, much less 20 of them. Nothing else of interest is in the closet, so you return your attention to the Master Bedroom.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    masterbedroomChoose();
                    break;
                case 3:
                    //window - nothing
                    ItemSearches.nothing();
                    break;
                case 4:
                    //bathroom - use code from FrontHouse
                    FirstFloor.FrontHouse.bathroom();
                    break;
                case 5:
                    //wardrobe - body, note, code
                    WriteLine("You inspect the Wardrobe.\nAs you walk closer, the faint odor grows stronger and more unpleasant.\n You open the Wardrobe...");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();

                    WriteLine("... and a body tumbles out!");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();

                    WriteLine("The body is of a man, over 6 feet tall, with salt-and-pepper hair, a thin build, and a not-quite-middle-aged face.\nHis shirt appears to have been shredded, along with the torso underneath!\n");
                    WriteLine("You inspect the body. You find a piece of paper inside the front right pocket. On it, in a small, hurried-looking print is this:\n\n'She dabbled too deep! She is now a Lou-");
                    WriteLine("The note is torn off at that point.\nYou don't know what a 'Lou' is but whatever it is, it sounds dangerous... and not natural.\n\nYou take the Note and pocket it, then put the body back into the Wardrobe - gruesome work.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    masterbedroomChoose();
                    break;
                case 0: default:
                    WriteLine("You have exited the program.");
                    break;                    
            }
        }

        public static void diningRoom()
        {
            Console.Clear();
            WriteLine("You open the door ahead and peer in.\n\nIt is a Dining Room, a very nice Dining Room, too! The main feature is the cherry room table that sits in the middle of the room, surrounded by 8 chairs of equal beauty.\nIn the far left corner, there is a china cabinet with a few nice-looking dinner sets.\nA large window, set into the far wall, would let light into the room; the only light available from outside, right now, is the light from a full moon.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();

            WriteLine("|-------------------------------------------------------------------|");
            WriteLine("|                    |                        |                     |");
            WriteLine("|                    |                        |                     |");
            WriteLine("|                    |      Dining Room       |                     |");
            WriteLine("|                    |                        |                     |");
            WriteLine("|                    |                        |                     |");
            WriteLine("|---------\\----------------------\\--------------------||---------\\");
            WriteLine("|--------\\---------------\\----       -----------------------------|");
            WriteLine("|                     |         |      |                            |");
            WriteLine("|                     |         |      |        Living Room         |");                 
            WriteLine("|                     |         |      |                            |");
            WriteLine("There is an elaborate, crystalline chandleer hanging from the ceiling; the lights are on.\n There a couple of chairs in the far right corner of the room.\nYou don't see anything else of significance but you do have the oddest feeling: 'this room is... safe'.\n\nYou leave the Dining Room and return to the T-intersection.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            tHall();

        }

        public static void kitchen()
        {
            WriteLine("You take the right branch of the new hallway and go to the door on the left.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();

            WriteLine("You enter the Kitchen.\n You use your flashlight to locate the light switch; you flip the switch.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();

            WriteLine("|-------------------------------------------------------------------|");
            WriteLine("|                    |                        |               Stairs|");
            WriteLine("|                    |                        |                     |");
            WriteLine("|                    |                        \\                     |");
            WriteLine("|                    |                        |      Kitchen        |");
            WriteLine("|                    |                        |                     |");
            WriteLine("|---------\\----------------------\\-----------------------||---------\\");
            WriteLine("|--------\\---------------\\----       -------------------------------|");
            WriteLine("|                     |         |      |                            |");
            WriteLine("|                     |         |      |        Living Room         |");                 
            WriteLine("|                     |         |      |                            |");
            WriteLine("As the lights come on, two things immediately strike you: this room gives off a 'bad' vibe, and that vibe is coming from the stairs.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine(); 

            WriteLine("The stairs are set into the wall to your right, in the far corner, leading down into darkness. Red streaks run between the entrance door and the stairs; you are certain that they are blood stains.\nThe rest of the Kitchen isn't much better.\nOn the left wall, there is - WAS - a door, leading to the Dining Room; that door is now laying on the floor, shattered by some extreme force.\nThere is a kitchen island in the center of the room, with 4 high-backed stools set on the end closest to you.\nCabinets are mounted on 3 of the walls - only the wall to your left is void of them.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            
            WriteLine("A lot of the cabinet doors are cracked, have scratches in them, and a myriad of other types of damage to them.\nThere are more 'red stains' on the floor, in the sink, and on top of a stove against the wall to the right. The stove also has something written on the oven door.\nThere are broken dishes in the sink and on the floor, in front of the sink.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            kitchenChoose();
        }    
        public static void kitchenChoose()
        {
            WriteLine("What do you want to do next?");
            WriteLine("'1' to examine the Kitchen Island\n'2' to examine the Stove and Oven\n'3' to examine the Cabinets\n'4' to check out the Stairs\n'5' to exit the Kitchen\n'0' to Quit the Program");

            var kitchenChoice = Int32.Parse(Console.ReadLine());

            switch (kitchenChoice)
            {
                case 1:
                    //kitchen island
                    WriteLine("You take a closer look at the Kitchen Island.\nThere's nothing remarkable about the stools surrounding the island.\nOn top of the island itself, there is a science magazine, a newspaper, and some sheets of paper with various writings and drawings on them.\nOn one of these sheets is a series of figures: a triangle, with circles drawn around the points of each triangle, and each circle is a different color: red, blue, green.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    WriteLine("The other sheet of paper is a clipping of a newspaper article from 3 days ago. It is one of those articles that you find in the 'Communities' section; this one deals with some of the superstitions about the Full Moon.\nAn interesting article, you pocket the article and drawings and continue in the Kitchen.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    kitchenChoose();
                    break;
                case 2:
                    //Stove; code
                    WriteLine("You inspect the stove closer.\nThe writing on the stove is a set of numbers:\n'7521'.\nPress 'Enter' to continue with the Kitchen Search.");
                    Console.ReadLine();
                    kitchenChoose();
                    break;
                case 3:
                    //Cabinets
                    WriteLine("You check each wall of cabinets, starting with the wall to the right, going counterclockwise.\n");
                    WriteLine("These cabinets, sitting above the stove, contain spices and condiments, containers of what look like cereals and oatmeal, and containers of flour. Nothing else of interest is in these cabinets.");
                    WriteLine("The middle set of cabinets contain dishes, plastic containers, glasses, and cups. Nothing else catches your eye. Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    WriteLine("The last set of cabinets contains canned goods, various jarred foods, and some various snack crackers. On top of some of the canned goods is a piece of folded paper. It is a newspaper article from last month, with the title:\n'3 More Mutilated Bodies Found'.\n");
                    WriteLine("The article states that 12 bodies have now been found in the last 3 months: 3 last month, 5 the month before, 4 the month before that. They all have been found 1-2 nights before the full moon... and most have been found in the neighborhood of the Adams Manor.\nUh oh.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    WriteLine("You pocket the news article.\nYou continue the Kitchen search.");
                    kitchenChoose();
                    break;
                case 4:
                    //stairs
                    //start of 'Basement' namespace
                    WriteLine("Despite inner warnings going off in your head, you decide to go down the stairs.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    WriteLine("The stairs have an odd odor to them, one you can't quite identify.\nYou notice that, on both sides of the stairs, on the walls, those same triangle-circle glyphs are drawn, in a dark-colored chalk or charcoal.\nThere are also small drops of blood on the stairs.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    Basement.Rooms.stairs();
                    break;
                case 5:
                    WriteLine("You decide to leave the Kitchen - you don't trust the feeling coming from the stairs.\nYou back to the T-intersection to gather your thoughts.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();   
                    tHall();
                    break;  
                case 0: default:
                    WriteLine("You have exited the program.");
                    break;
            }
        }
    }
}