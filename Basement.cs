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
        public static void beforeGarou()
        {
            WriteLine("The door opens onto a small hall that turns to the right.\nYou sneak up to the turn of the hall and see a very large chamber.\nThere are brightly glowing glyphs everywhere, except for the far side of the room. Instead, there is a large, glowing chalk circle on the ground. Inside of it, with it's back turned away from you, is a squatting figure.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();

            WriteLine("Even squatting, you can tell that the figure is well over 6 feet tall.\nIt is also a woman. She has not notice your presence.\nWhat do you do next?");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            beforeChoose();
        }
        public static void beforeChoose()
        {
            WriteLine("1. Enter the Chamber and Engage Her\n2. Stay Where You're At\n3. Retreat Back to the Stairs");
            var bossChoice = Int32.Parse(Console.ReadLine());

            switch(bossChoice)
            {
                case 3:
                    // retreat
                    WriteLine("You back up - SLOWLY - and close the steel door behind you.\nYou stop at the base of the stairs that led down from the kitchen, trying to formulate some plan...");
                    stairs();
                    break;
                case 2:
                    // hold
                    WriteLine("You hold your position.\nAs you crouch, you hear a voice from the chamber:\n'I'm going to give you 30 seconds to leave before I come for you.'\nDo you leave?"); 
                    WriteLine("1 - Yes\n2 - No");
                    var leave = Int32.Parse(Console.ReadLine());
                    if(leave == 1)
                    {
                        WriteLine("That voice did not remotely sound like it came from a woman... or a human. Completely unnerved, you leave the hall, close the steel door behind you, and leave the basement.\nYou head back through the kitchen, to the entry, and out the door.");
                        WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();

                        WriteLine("Standing on the porch, you wonder how you are going to report what - ");
                        WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();

                        WriteLine("To your left, something shambles towards you. It looks like... like a zombie?!? Before you can comprehend what you are seeing, it lunges at you with incredible speed.\And large claws.\nThose claws devastate your chest and torso in one gigantic rake.\nYou are dead before your body hits the ground, as 3 other similar creatures - Ghasts - emerge from the trees to feed.");
                        System.Environment.Exit(0);
                    }
                    if(leave == 0)
                    {
                        WriteLine("You ignore the dread that threatens to overwhelm you after hearing that voice.\nYou load your gun with some of the silver bullets, take a deep breath, and walk around the corner...");
                        WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();

                        bossFight();
                    }
                    break;
                case 1:
                    bossFight();
                    break;
                default:
                    WriteLine("You have exited the program.");
                    System.Environment.Exit(0);
                    break;

            }

        }

        public static void bossFight()
        {
            //refactor old code
            WriteLine("You walk around the corner, into the chamber. The figure turns around to face you.\nIt is a red-haired woman, with very piercing blue eyes. You recognize her, vaguely, as Ros Adams, the 'missing' wife of the Adams Manor.\n\nNothing else about her resembles humanity.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();

            WriteLine("Her face looks too tall and... too long, almost like a muzzle.\nShe grins and displays rows of canine-like teeth.\nHer clothes are ripped but still mostly intact. However, what you can see of her body looks incredibly lean and powerful.\nBut what is the most disturbing are her eyes.\nThere is a combination of malevolence and... amusement?... in those eyes that make you weak in the knees\nShe will likely enjoy killing you, if given the chance!");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();

            WriteLine("You shout: 'I know about this place, Ros! I know that you have dabbled in the occult! I know that you fatally wounded your husband! I know that you are possessed and like it! I'm ending this NOW!'");
            WriteLine("Ros Adams just responds with a low, inhuman chuckle, and starts towards you.\n You pull out the gun, start circling the room, and take aim...!");
            
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();

            // setting up variables for the encounter
            int healthLoupGarou = 100; 	// or higher; adjust, if time
            int playerHealth = 60; 	// or higher
            int armorLoupGarou = 14;
            int armorPlayer = 10;
            
            

            // loop for the fight
            // the player and LG ‘roll’ a d20 to hit; if they connect, they do damage
            // the player ‘rolls a d8’ to damage, the LG rolls a d12; critical hits occur at the max value – double damage

            while((healthLoupGarou > 0) || (playerHealth > 0))
            { 
                if(playerHealth <= 0)
                    playerEnd();
                if(healthLoupGarou <= 0)
                    loupGarouEnd();     
                
                Console.WriteLine("You have {0} Hit Points, while Ros-Loup-Garou has {1} Hit Points.", playerHealth, healthLoupGarou);
                
                Console.WriteLine("You take a shot…");
                
                // for the player
                Random rd = new Random();
                int roll = rd.Next(1, 21);      // simulating a 20-sided die roll
                Random dmg = new Random();
                int damage = dmg.Next(3,11);     // 3-10 points of damage per shot

                if(roll >= armorLoupGarou)
                {		
                    WriteLine("Hit! You do {0} points of damage!", damage);
                    healthLoupGarou -= damage;
                    WriteLine("It now has {0} Hit Points", healthLoupGarou);
                }
                else
                {
                    WriteLine("Miss!");
                }
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();

                WriteLine("Ros attacks with her claws…");

                // for the Loup-Garou
                Random rl = new Random();
                int rollLG = rl.Next(1, 21);
                Random dmgg = new Random();
                int damageLG = dmgg.Next(1,13);     // 1-12 points of damage per attack

                if(roll >= armorPlayer)
                {
                    WriteLine("Hit! It does {0} points of damage!", damageLG);
                    playerHealth -= damageLG;
                    WriteLine("You now have {0} Hit Points", playerHealth);
                }
                else
                {
                    WriteLine("Miss!");
                }
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
            }

        }

        public static void playerEnd()
        {
            WriteLine("You lost a lot of blood from Ros's attacks.\nYou fire wildly, only for her to backhand you across the chamber, into the wall.\nShe rushes over to you, looks down, and says: 'You meddled in affairs that didn't concern you. Fatal mistake.'\nShe swings her claws at your upper body, essentially decapitating you.");
            System.Environment.Exit(0);
        }
            
        public static void loupGarouEnd()
        {
            WriteLine("The Ros-Loup-Garou, despite its impressive resilience, speed, and strength, is looking very wounded and very ticked off. It crouches down, snarling and growling, ready to pounce.\nYou take a deep breath to steady yourself, aim the Gun, and fire, as she leaps…");
            WriteLine("Your shot lands true.");
            WriteLine("The shot hits the Loup-Garou in the upper forehead, knocking it off-course.\nIt lands with a VERY heavy ‘thud’, rolling towards the steel door.\nThe body starts to… change. It shrinks in height, the face starts to shrink… what’s left is the body of a more-humanl-like Ros Adams.\nAnd there is the strangest sight: the woman looks… content?");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            
            WriteLine("Ros Adams wanted the power of the Spirit World, for whatever reasons.\nShe tried a summoning spell and failed, ending up possessed and turned into a Loup-Garou.\nShe seemingly killed her husband - and possibly many more - before locking herself in the glyph-warded chamber.\nYou report back to the group that sent you, bringing the Gun and other items you might have found.\nThe group is pleased with your work: you solved the case of the Adams Manor!");
        }
        
    }
}