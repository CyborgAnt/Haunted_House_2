//second floor
//intro code

using System;
using System.Text;
using static System.Console;

class SecondFloorRooms
{
    
    public static void stairs()
    {
        //hub for the 2nd Floor
        WriteLine("You are at the top of the stairs, on the second floor of the Adams Manor.\n");
        WriteLine("You walk a short distance until you come across a hall, stretching left and right.\nPress 'Enter' to continue.");
        Console.ReadLine();

        WriteLine("To the left, there is a door at the end of the hall before the hall turns left. There is also a door on the left, just a few feet from the stairs.\nTo the right, the hall stretches for a few dozen feet before turning to the right. There is a door just to the right of the stairs.\nIn front of the stairs, there is an open door, looking in on a Guest Room or a Bedroom.\nPress 'Enter' to continue.");

        Console.ReadLine();
        secondFloorStairsChoose();
    }
    public static void secondFloorStairsChoose()
    {
        WriteLine("--------------\\--------------");
        WriteLine("\\                            ");
        WriteLine("    ---\\---     ---\\---    ");
        WriteLine("|   |       |STR |       |   |");
        WriteLine("|   |       |    |       |   |");
        WriteLine("'\' - Door\n'STR' - Stairs");
        
        WriteLine("Which way do you go?");
        WriteLine("'1' to take the Left Hall and check the Closest Door\n'2' to take the Left Hall and check the Farthest Door\n'3' to take the Left Hall but skip both doors\n'4' to take the Right Hall and check the Closest Door\n'5' to take the Right Hall but Skip the Closest Door\n'6' to go back down the Stairs\n'7' to check the Door straight ahead\n'0' to Quit the Program");
        var upperStairsChoice = Int32.Parse(Console.ReadLine());

        switch (upperStairsChoice)
        {
            case 1:
                //Left - BTWall
                behindTheWalls();
                break;
            case 2:
                //Left - Bath2
                bathroom2();
                break;
            case 3:
                //Left - Hall
                SecondFloorHalls.hallLeft();
                break;
            case 4:
                //Right - BTWall
                behindTheWalls();
                break;
            case 5:
                //Right - Hall
                SecondFloorHalls.hallRight();
                break;
            case 6:
                //Stairs
                WriteLine("You return to the Stairs. You descend back into the Living Room. Press 'Enter' to continue.");
                Console.ReadLine();
                FirstFloor.FrontHouse.livingRoom();
                break;
            case 7:
                //Bedroom2 - change the trap
                bedroom2(); 
                break;
            case 0: default:
                //exit code
                WriteLine("You have exited the Program.");
                System.Environment.Exit(0);
                break;
        }
    }

    public static void bedroom2()
    {
        //Statue-puzzle: DELELTE
        WriteLine("You open the door and look upon a sparse bedroom.\nThis room is... different. Press 'Enter' to continue.");

        Console.ReadLine();
        Console.Clear();

        /* WriteLine("From the doorway, there is a bed to the left, against the wall. On the bed appears to be a note.\nAcross the room, in the right corner, is a 7-foot tall statue. The statue resembles a crouching Gargoyle, with its hands outstretched. In its left hand is what appears to be a stone box; the right hand is holding a sword, tip down.\n\nBetween the bed and the Gargoyle statue, on the floor, is a grid of numbers and letters. Press 'Enter' to continue.");

        Console.ReadLine();

        WriteLine("-----------------------");
        WriteLine("|| A | 8 | 4 | 1 | G ||");
        WriteLine("|| 9 | 7 | @ | 0 | 2 ||");
        WriteLine("|| T | Q | 6 | 5 | 3 ||");
        WriteLine("-----------------------");

        WriteLine("What do you do next?\n");
        WriteLine("'1' Check the Grid\n'2' Check the Bed\n'3' Check the Statue\n'4' Go back into the Hall");
        var upperBedChoice = Int32.Parse(Console.ReadLine());

        switch (upperBedChoice)
        {
            case 1:
                //grid
                WriteLine("Code coming soon!");
                break;
            case 2:
                //bed - Note
                WriteLine("You walk over to the bed and take a closer look at the note.\n\nIt looks like some form of poetry or code. 'Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();

                WriteLine("Walk a path of 5, to open the box.\nMisstep and feel the wrath of Moon's Enforcer.\n\n2 steps to describe the love of my life, 2 steps for the year my son was born. Take the 5th step on the center to reveal your fate. Press 'Enter' to continue.");
                Console.ReadLine();
                
                WriteLine("Do you step on the grid?\n'1' for 'Yes'\n'2' for 'No");
                var gridChoice = Int32.Parse(Console.ReadLine());
                switch (gridChoice)
                {   
                    case 1:
                        Encounters.grid();
                        break;
                    case 2:
                        WriteLine("You pocket the Note but decide not to test out the Grid, yet. You return to the doorway to think things through.\n"); 
                        bedroom2();
                        break;
                    
                    default:
                        break;
                }
            break;
            case 3:
                //Statue - check
                WriteLine("You walk towards the Statue, being careful NOT to walk on the grid on the floor.\nYou walk around the Statue, looking for any kind of detail. You notice that there are scuff marks around the base of the statue, leading towards the door. You also notice that the right arm is hinged at the elbow and shoulder.\nThe box in the left hand hand looks solid - you don't see any visible lid or openings.\n\nYou walk back around the grid and head towards the door. Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                bedroom2();
                break;    
            default:
                WriteLine("You have exited the Program.");
                System.Environment.Exit(0);
                break;
        }
        */
    }

    public static void masterBedroom2()
    {
        //bullets; secret door to Basement
        WriteLine("You enter the room from the Hall. You use your flashlight to locate a light switch. \nYou locate the switch, flick it up, and the room is illuminated. Press 'Enter' to continue.");

        Console.ReadLine();
        Console.Clear();

        WriteLine("You see an enormous bedrrom! It could - and might have, at one time - double as a Studio apartment.\nFrom the doorway, there is a large bed in the left corner, next to a big window. Across from the bed, on the left side of the room, is a standing Wardrobe.\nAlmost directly across from the door is some sort of writing desk, with papers scattered on top of it; the desk sits in front of two parallel windows.\n Press 'Enter' to continue.");
        Console.ReadLine();

        WriteLine("The right side of the room - looking from the doorway - is a little less furnished.\nThere is a bench against the wall, to the right of the door and on the opposite wall, next to the desk.\nThere is a doorway on the right wall - it opens onto a bathroom. To the right of the bathroom doorway, there is a closet, although you can't quite see what's in it. As you turn back around, you notice something sticking out of the wall, between the door and the bed. What do you do next?");

        WriteLine("\n1. Check the Closet\n2. Check the Desk\n3. Check the Wardrobe\n4. Check the Object in the Wall\n5. Check the Bathroom\n6. Leave the Master Bedroom");
        var MBR2 = Int32.Parse(Console.ReadLine());
        Console.Clear();
        switch (MBR2)
        {
            case 1:     //closet
                WriteLine("You walk over to the Closet and look in.\nOther than standard clothes, you don't notice anything of importance. However, on the top shelf, you see a box of bullets.\nOpening the box, you see 20 SILVER BULLETS. You close the box, pocket it, and look around the room once more. Press 'Enter' to continue.");
                //silverBullets += 20;
                Console.ReadLine();
                Console.Clear();
                masterBedroom2();
                break;
            case 2:     //desk
                WriteLine("You check the papers on top of the desk.\nThere are seemingly random scribbles about 'The Gateway' and 'Twin Orbs' but there's not enough info to make much sense.");
                WriteLine("You next check the bathroom.\nPress 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                bathroom3();
                break;
            case 3:     //Wardrobe - Orb
                // remove Orbs from the code
                /* WriteLine("You walk over to the Wardrobe and open the doors.\n\nIt's almost empty, except for some shoes on the ground and a lone, pale green dress on a hangar.\nYHowever, a closer look reveals a purple box on the ground, behind the shoes. You open the box to reveal...\n...a Dark Blue ORB. You also see a 3-digit number on the box: '331'. Press 'Enter' to continue.");

                Console.ReadLine();
                Console.Clear();

                WriteLine("This may be what some writings you came across earlier were referring to: 'Twin Orbs'. If you haven't found it already, you might want to find the second Orb - it seems like it might be important.");
                WriteLine("You decide on your next move, as you head back to the door. Press 'Enter' to continue.");

                */
                WriteLine("New code to come! Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                masterBedroom2();
                break;    
            case 4:     //Object - Switch
                WriteLine("You walk over to the object in the wall.\n\nIt is small, silver-colored, shaped like a dagger hilt, although the blade is missing.\nYou reach to grab it; as you grab it, the object slides into the wall!\nA section o0f the wall, between the Bathroom door and the corner, slides open, revealing a set of stairs that lead down. Do you descend the stairs? Enter '1' for Yes, anything else for 'No'");
                var down = Int32.Parse(Console.ReadLine());

                if(down == 1)
                {
                    WriteLine("You walk down the revealed stairs. It is a long flight of stairs; at the bottom, there is a wall... a section of the wall suddenly opens. Press 'Enter' to continue.");
                    // basement: wall near Gate
                    WriteLine("You emerge in the antechamber of the basement.");
                    Basement.Rooms.antechamber();
                }
                else
                {
                    WriteLine("You ignore the stairs... for the moment. You head back to the door. Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    masterBedroom2();
                }
                break;
            case 5:     //bathroom
                bathroom3();
                break;
            case 6:     //leave
                WriteLine("You decide to go leave the room.");
                SecondFloorHalls.hallRight();
                break;

            default:
                WriteLine("You have exited the Program.");
                System.Environment.Exit(0);
                break;
        }

        //mbrSecond();
    }

    public static void mbrSecondChoose()    
    { 
        WriteLine("\n1. Check the Closet\n2. Check the Desk\n3. Check the Wardrobe\n4. Check the Bathroom\n5. Leave the Master Bedroom");
        var secretChoice = Int32.Parse(Console.ReadLine());
        Console.Clear();
        switch (secretChoice)
        {
            case 1:     //closet
                WriteLine("You walk over to the Closet and look in.\nOther than standard clothes, you don't notice anything of importance. However, on the top shelf, you see a box of bullets.\nOpening the box, you see 20 SILVER BULLETS. You close the box, put it in your back pack, and look around the room once more. Press 'Enter' to continue.");
                //silverBullets += 20;
                Console.ReadLine();
                Console.Clear();
                masterBedroom2();
                break;
            case 2:     //desk
                ItemSearches.nothing();
                break;
            case 3:     //Wardrobe - Orb - REMOVE OR CHANGE
                WriteLine("You walk over to the Wardrobe and open the doors.\n\nIt's almost empty, except for some shoes on the ground and a lone, pale green dress, hanging.\nPress 'Enter' to continue.");
                //However, a closer look reveals a purple box on the ground, behind the shoes. You open the box to reveal...\n...a Dark Blue ORB. WriteLine("This may be what some writings you came across earlier were referring to: 'Twin Orbs'. If you haven't found it already, you might want to find the second Orb - it seems like it might be important.");
                Console.ReadLine();
                Console.Clear();

                WriteLine("You then notice the brochure next to the shoes: \n'Possessions are REAL!'.\nSkimming the brochure, it talks about how people, with sufficient training, can withstand a possession, turn the entity out, but keep all of it's powers. The drawback is that if the entity regains control, it can - and usually will - kill the person and anyone close to them.\nCREEPY.");

                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();

                WriteLine("You decide on your next move, as you head back to the door. Press 'Enter' to continue.");
                Console.ReadLine();
                mbrSecondChoose();
                break;    
            case 4:    //bathroom
                bathroom3();
                break;
            case 5:     //leave
                WriteLine("You decide to go leave the room.");
                SecondFloorHalls.hallRight();
                break;

            default:
                WriteLine("You have exited the Program.");
                System.Environment.Exit(0);
                break;
        }

    }

    public static void bathroom3()
    {
        WriteLine("You look into this room. It is another bathroom, although it's slightly smaller than the one you saw on the first floor.\nThere is nothing of particular interest, so you go back to the Master Bedroom. Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();
        masterBedroom2();
    }

    public static void porch()
    {
        //see movement in the yard
        WriteLine("You open the door and step out onto a 2nd Floor porch. Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();

        WriteLine("There are a couple of wicker chairs on the porch, along with a loveseat.\nEven in the late evening light, you still have a pretty nice view from the porch.\nYou can see the ample front yard, movement in the yard, the trees off to the side, the -\n");
        WriteLine("Wait. You focus your gaze back on the front yard. There is someone - or someTHING - circling the house, in a slow, shuffling gait.\nIt appears to have ragged clothes on... and something about its face seems... wrong.\nIt hasn't noticed you on the Porch, yet.\n At this point, you decide a few things: \n1. This person or thing might be one of the sources of the 'strange sights' reports\n2. Between this and some of the items that you've seen so far, there is a supernatural element to this house, one that you don't like\n3. You need to wrap this up before it gets too dark outside. You have a gut feeling that you don't want to be outside the House at night.");
        WriteLine("You head back inside. Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();
        SecondFloorHalls.hallBottom();
    }

    public static void office()
    {
        //code; rewrite
        WriteLine("You look in the door and see an Office.\nFrom the hallway door, there is another door on the wall to the left, leading to a screened-in porch.\nIn the corner, there is a bookcase.");
        WriteLine("On the left wall of the room, there is another bookcase next to the first one.\nAgainst the wall, across from the door, are two desks: the larger desk has a computer, speakers, two monitors, and an office chair; the small desk has a printer, a ream of paper, some scattered loose papers on it, and a second office chair.");
        WriteLine("On the right wall of the room, there is an open door, looking in on some kind of storage room or closet.\nNext to the door is a large floor lamp.\nIn the center of the room are a few stacks of books and boxes; the boxes appear to be mainly files and old magazinews.");
        WriteLine("Press 'Enter' to continue.");

        Console.ReadLine();
        Console.Clear();
        WriteLine("What would you like to do?");
        WriteLine("'1' to Check the Large Desk\n'2' to Check the Small Desk\n'3' to Check the Porch\n'4' to Check the Closet\n'5' to Check the Boxes and Books\n'6' to Leave the Office");
        var officeChoice = Int32.Parse(Console.ReadLine());

        switch (officeChoice)
        {
            case 1:     //Large Desk
                WriteLine("You check the Large Desk, specifically the Computer on the desk. Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();

                WriteLine("The computer does not appear to be locked - SHAME! - so you start checking out the browsing history.\nThere are searches and web sites on a lot of occult topics. Two themes seem to pop up the most: 'Possession' and 'Protection Glyphs'.\nA disturbing article on Possession deals with the results when someone tries to summon a powerful spirit or Demon and it doesn't go as planned. The spirit/Demon may turn the summoner into a wolf-like monster known as a Loup-Garou. It walks upright, resembles a 'werewolf', and is resilient to almost all damage that isn't from Silver. It also is extremely evil. Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();

                WriteLine("You stop reading. A 'Loup-Garou', like from the Jim Butcher books?? There's no way those things are real...! Press 'Enter' to continue.");
                Console.ReadLine();

                WriteLine("Nevertheless, you take notes on what you read, and exit the computer. Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                office();
                break;
            case 2:     //Small Desk - glyphs
                WriteLine("You examine the top of the small desk.\nThere are over a dozen pages that have similar drawings on them:\nA triange, with each point surrounded by a different colored circle: red, dark blue, and green.\nHowever, one of the pages has a description written on it. Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();

                WriteLine("'The Trisect Alignment'\n'The Trisect Alignment is a powerful glyph, used to not only contain hostile entities but to weaken them in their containment. The glyph combines the strength of the heart of the glyph creator (Red Circle) with the strengh of the Spirit (Green Circle), and adds an element of supernatural protection (Blue Circle). It is especially potent versus Lycanthropes, such as werewolves, and their more demonic cousin, the Loup-Garou. In the case of the Loup-Garou, the possessed person will ward a particular room or rooms with the Trisect Alignment and spend the night of the full moon in the room, where the Alignment weakens the Bloodlust in the Loup-Garou.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                WriteLine("You finish searching the Small Desk. The hairs on the back of your neck are standing up at Full Attention: what is going on in this place??");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                office();
                break;
            case 3:     //Porch
                porch();
                break;
            case 4:     //Closet
                WriteLine("You walk over to the door to the Closet and look in. Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                upstairsCloset();
                break;
            case 5:     //Boxes
                WriteLine("You examine the boxes and books.\nOn top of one of the stacks of books is a leather-bound book, with 'The Changing' written on the front. Ominous!\n You walk over, shut the Office door - just in case - and sit at the smaller desk. You open the book and flip through the pages. Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                
                Encounters.diary();        //under "Encounters"
                WriteLine("You are absolutely terrified: you will probably have to fight - and kill - Ros Adams to close this case, because you have no doubt that she is the ultimate cause of all of the reports surrounding this House.");
                WriteLine("You leave Office and go back into the Hall, resolving to finish this search of the 2nd Floor quickly. You have a date with Ros Adams.");
                SecondFloorHalls.hallLeft();
                break;
            case 6:     //Leave
                WriteLine("You leave the Office and go back into the hallway.\n");
                SecondFloorHalls.hallLeft();
                break;        
            default:
                WriteLine("You have exited the Program.");
                System.Environment.Exit(0);
                break;
        }

    }

    public static void upstairsCloset()
    {
        //info on Billy Adams; resurrected?
        WriteLine("You open the door and see a very large closet, almost a storage room. \nYou notice boxes and crates everywhere. On top of a stack of furniture, you notice an odd pamphlet:\n'Resurrection and What To Beware Of'\n");
        WriteLine("More code later!");
    }

    public static void bathroom2()
    {
        //nothing
        WriteLine("You turn down the Left Hall, skip the doors closest to you, and head to the door at the end of the Hall. Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();
        WriteLine("You see a fairly large, relatively clean Bathroom. This was probably used as a Guest bathroom.\nYour standard bathtub, sink, shower head, and toilet are present but look practically spotless, compared to the rest of the house.\nThere are folded towels in a small closet, along with extra bath items like shampoo and body wash.\nNothing else seems out of the ordinary, so you leave the Bathroom and decide your next move. Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();
        stairs();
    }

    public static void behindTheWalls()
    {
        //code on wall; wires
        WriteLine("You enter a narrow, U-shaped room.\nThis looks like a space where wires and cables that go between the floors of the house can run, without being seen.\nPress 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();

        WriteLine("There are plenty of single and bundled wires, cords, and thicker, woven cables, running down (and into) the walls, and along the ceiling.\nThere are also, in regular intervals, small wooden shelves, set into the walls; on these shelves are various small tools, clamps, and fasteners. In a few spaces, there are also small work benches, with various tools, manuals, and papers on them.\nThis is a makeshift work shop.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();

        WriteLine("As you walk around the room, you notice on one of the larger work benches, a manual: 'The Guardian Door'.\nYou have a few choices - what would you like to do?");
        WriteLine("Press 'Enter' to continue.\n");
        Console.ReadLine();
        behindWallsChoose();
    }
    public static void behindWallsChoose()
    {
        WriteLine("'1' to Check out the Manual\n'2' to Check the other Small Shelves\n'3' to Check the other Work Benches\n'4' to Check the Room\n'5' to Leave the Room through either Door\n'0' to Quit the Program");

        var btwChoice = Int32.Parse(Console.ReadLine());

        switch (btwChoice)
        {
            case 1:
                //Manual
                WriteLine("Code is coming!");
                break;
            case 2:
                //shelves - nothing
                WriteLine("You check the shelves of the room. There are some randome hardware - wires, loose bolts, etc. - and some other odds and ends, but you see nothing else of note.");
                behindWallsChoose();
                break;
            case 3:
                //work benches - code on paper, drawings?
                WriteLine("You don't see much of importance; what you find are pages from manuals, schematics, and some random notes.\nOn one sheet paper, however, you find just a 4-digit number:\n'7521'.\nYou make a mental note of the number.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                behindWallsChoose();
                break;
            case 4:
                //notice glyphs on wall
                WriteLine("As you walk around the room, you notice that there are drawings on the walls, specifically near the doors and back by the thick wires running into the walls. You may have seen them in other parts of the house: A triangle, with red, green, and blue circles drawn around the points of the triangle.\nThese drawings are also scratched into the floor, although the circles are all black; maybe they are unfinished?\nYou leave the room and go back to the stairs; it's a central, safe area to plan your next move. Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                stairs();
                break;
            case 5:
                //leave
                WriteLine("You end your inspection of the U-shaped room and back to the Stairs.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                stairs();
                break;       

            case 0: default:
                WriteLine("You have exited the Program.");
                System.Environment.Exit(0);
                break;
        }
    }
}

class SecondFloorHalls
{
    public static void hallLeft()
    {
        //Hallway to the left of the floor
        Console.Clear();
        WriteLine("You turn down the hall to the left.\nAbout 3/4 down the hall, you see 2 doors on the right.\nOne door looks like it leads to a large room; the other door is near the corner, where the hall turns again to the left.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();
        
        WriteLine("-----------------");
        WriteLine("\\               ");
        WriteLine(" Here --------");
        WriteLine("|    |       | |");
        WriteLine("|    |       | |");
        WriteLine("|    |       | |");
        WriteLine("\\   |       | |");
        WriteLine("|    |       | |");
        WriteLine("|    |       | |");
        WriteLine("\\   |       | |");
        WriteLine("|    --------- |");
        WriteLine("|--------------|");
        WriteLine("\nWhat would you like to do?");

        WriteLine("1. Enter the closest door\n2. Enter the farthest door\n3. Go around the corner, skipping the doors\n4. Go back to the Stairs");
        var hallChoiceLeft = Int32.Parse(Console.ReadLine());

        switch (hallChoiceLeft)
        {
            
            
            default:
                WriteLine("You have exited the Program.");
                System.Environment.Exit(0);
                break;
        }  

    }
    public static void hallRight()
    {
        //Hallway to the right of the floor
        WriteLine("Code is coming!");
    }
    public static void hallBottom()
    {
        //Hallway to the bottom of the floor
        WriteLine("Code is coming!");
    }
}