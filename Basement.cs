// Basement
using System;
using System.Text;
using static System.Console;

namespace Basement
{
    class Rooms
    {
        public static void stairs()
        {
            WriteLine("You arrive at the landing at the bottom of the stairs, from the Kitchen.\nThere are glyphs all over the floor and walls of the landing. Beyond the landing, there is a large room, possibly a Family Room or Entertainment Room.\n\nYou enter this room and notice what looks like a safe on the left wall. There is an open door on the right wall; it looks like the door opens on to a laundry room.\n There is a bar area on the left, next to the safe, lined with stools.\nThere is a doorway on the far end of the room, closed. Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();

            WriteLine("What do you do?");
            WriteLine("1 - Check the Safe\n2 - Check the Bar\n3 - Check the Laundry Room\n4 - Check the Door on the Far End\n5 - Go Back up the Stairs");
            var basementChoice = Int32.Parse(Console.ReadLine());
            switch (basementChoice)
            {
                case 1:
                    //Safe
                    ItemSearches.safe();
                    break;
                case 2:
                    //Bar - Gun
                    WriteLine("You walk over to bar and examine it.\n\nThe bar has a nice wooden counter; the area behind the bar is well-stocked with different hard liqours.\nYou look under the bar and notice a drawer. Opening it, you pull out a large GUN and a box of 20 SILVER BULLETS! Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    WriteLine("You put the new gun in your waistband - it never hurts to have backup weapons. You continue on to the Laundry Room....\n\n");
                    //case 3;         // not sure I can do this
                    break;
                case 3:
                    //Laundry Room
                    WriteLine("You enter the Laundry Room.\nThis room has been ravaged.\nThe washer and dryer are still standing but they have been dented and scratched. There is a counter in the back of the room; most of the contents on the counter have been spilled, crushed, or crumpled.\nYou don't notice anything else of value or note in the room, so you head back to the beginning.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    stairs();
                    break;
                case 4:
                    //Door - Turn Around Warning
                    WriteLine("You ignore the features of the room and head for the far door.\n\nAs you put your hand on the doorknob, you get the feeling that this is one of your last chances to turn around. Do you open the door?");
                    WriteLine("1 - Yes, 2 - No, go back to the stairs");
                    var doorChoice = Int32.Parse(Console.ReadLine());

                    switch (doorChoice)
                    { 
                        case 1:
                            WriteLine("You continue on.\n");
                            antechamber();
                            break;
                        case 2:
                            WriteLine("You have 2nd thoughts about continuing on.\nInstead, you head back to the stairs to think things over, including possibly searching more of the House.");
                            WriteLine("Press 'Enter' to continue.");
                            Console.ReadLine();
                            Console.Clear();
                            stairs();
                            break;

                        default:
                            WriteLine("You have exited the Program.");
                            System.Environment.Exit(0);
                            break;
                    }
                    break;
                case 5:
                    //Leave
                    WriteLine("You ignore the room and go back up the stairs. Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    FirstFloor.Backhouse.kitchen();
                    break;
                default:
                    WriteLine("You have exited the Program.");
                    System.Environment.Exit(0);
                    break;
            }


        }

        public static void antechamber()
        {
            // wall section opens from Candle Holder, Bedroom stairs
            WriteLine("You turn the doorknob and pull the door open.\n");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();

            WriteLine("You see a large, square, empty room. There are only a few features in the room:\nThere is an opening in the left wall; there appear to be stairs that lead up into darkness\nThere are glowing glyphs on every wall and on the floor\nThere is a huge, steel door on the other side of the room.\n\nThere are a few options for you - what do you do?");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            WriteLine("1 - Stay out of the Antechamber\n2 - Investigate the Glyphs\n3 - Investigate the Door Across The Room\n4 - Investigate the Opening and the Stairs");
            
            var anteChoice = Int32.Parse(Console.ReadLine());
            switch (anteChoice)
            {
                case 1:     //stay out
                    WriteLine("The increasing unease of this basement is getting to you - something is not... right.\nYou not only stay out of the chamber, you decide to leave the basement, altogether.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    WriteLine("You head back upstairs to the kitchen, through the House, and back to the Entry.");
                    FirstFloor.FrontHouse.entryway();       //leads to the option to leave the house
                    break;
                case 2:     //Glyphs
                    WriteLine("You take a closer look at some of the glyphs on the walls and floors, closest to the doorway you are standing in.\nThey are glowing a bright but pale blue color but you do not see an obvious power source.\nThey are the same pattern that you might have come across before: a triangle, with a different colored circle around each point.\n");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear(); 
                    break;

                    WriteLine("You are careful to not disturb any of the glyphs, especially the ones on the floor. You think that they are warding you... but from what?\nYou decide your next move...");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    antechamber();
                    break;
                case 3:         //final, non-boss room
                    WriteLine("You walk over to the door and take a closer look.");
                    WriteLine("The door is made of thick steel. The glyph pattern that you've seen before is on the door: triangle-with-circles. The circles on the door, however, are actually circlualar recesses.\nEach recess has a softball-sized glass orb in it: red, green, aned blue.\n");
                    WriteLine("On the front of the door, right side, there are two buttons - one is red, the other is green.\nThe green button is glowing; this is likely a lock/unlock system. Press 'Enter' to continue.");
                    Console.ReadLine();

                    WriteLine("You push the green button.\nThere is an audible 'click!' as a lock disengages and the door swings open.\As the door opens, the glyphs on the wall and floor flare up. Press 'Enter' to continue.");

                    Console.ReadLine();
                    Console.Clear();
                    Garou();

                    break;    
                case 4: 
                    WriteLine("You walk over to the opening and look in.\nThere's a dark set of stairs that leads up. You take the stairs; as you approach the top, a section of the wall slides open!");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    WriteLine("You emerge in a bedroom!\nThis is a large bedroom. There is a wardrobe, a large closet in the corner, a large office desk, and various chairs and benches.\nThere is also a door that leads to a bathroom.\nWhat would you like to do?");

                    SecondFloorRooms.masterBedroom2();
                    break;
                default:
                    WriteLine("You have exited the Program.");
                    System.Environment.Exit(0);
                    break;
            }
        }
    }

    class Boss
    {
        public static void Garou()
        {
            WriteLine("The door opens onto a small hall that turns to the right.\nYou sneak up to the turn of the hall and see a very large chamber.\nThere are brightly glowing glyphs everywhere, except for the far side of the room. Instead, there is a large, glowing chalk circle on the ground. Inside of it, with it's back turned away from you, is a squatting figure.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();

            WriteLine("Even squatting, you can tell that the figure is well over 6 feet tall.");
        }
        
    }
}