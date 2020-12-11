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
                HouseFirst.FrontHouse.livingRoom();
                break;
            case 7:
                //Bedroom2 - puzzle/trap
                WriteLine("Code coming soon!");
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
        //Statue-puzzle
        WriteLine("You open the door and look upon a sparse bedroom.\nThis room is... different. Press 'Enter' to continue.");

        Console.ReadLine();
        Console.Clear();

        WriteLine("From the doorway, there is a bed to the left, against the wall. On the bed appears to be a note.\nAcross the room, in the right corner, is a 7-foot tall statue. The statue resembles a crouching Gargoyle, with its hands outstretched. In its left hand is what appears to be a stone box; the right hand is holding a sword, tip down.\n\nBetween the bed and the Gargoyle statue, on the floor, is a grid of numbers and letters. Press 'Enter' to continue.");

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
                WriteLine("Code coming soon!");
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



    }

    public static void masterBedroom2()
    {
        //bullets; secret door to Basement
        WriteLine("Code coming soon!");
    }

    public static void bathroom3()
    {
        //Imp?
        WriteLine("Code coming soon!");
    }

    public static void porch()
    {
        //see movement in the yard
        WriteLine("Code coming soon!");
    }

    public static void office()
    {
        //code; links on comp. about werewolves and Loup-Garou; description of glyphs
        WriteLine("Code coming soon!");
    }

    public static void upstairsCloset()
    {
        //info on Billy Adams; resurrected?
        WriteLine("Code coming soon!");
    }

    public static void mystery()
    {
        //portal room - unlocked via candleholder
        WriteLine("Code coming soon!");
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
        //code on wall; wires; info about Orb, Locket
        WriteLine("You open the door and enter a narrow, U-shaped room.\nThis looks like a space where wires and cables that go between the floors of the house can run, without being seen.\nPress 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();

        WriteLine("There are plenty of single and bundled wires, cords, and thicker, woven cables, running down (and into) the walls, and along the ceiling.\nThere are also, in regular intervals, small wooden shelves, set into the walls; on these shelves are various small tools, clamps, and fasteners. In a few spaces, there are also small work benches, with various tools, manuals, and papers on them.\nThis is a makeshift work shop.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();

        WriteLine("As you walk around the room, you notice on one of the smaller shelves a small, unlabeled, purple box.\nOn one of the larger work benches, a manual catches your eye: 'The Guardian Door'.\nYou have a few choices - what would you like to do?");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();

        WriteLine("'1' to Inspect the Purple Box\n'2' to Check out the Manual\n'3' to Check the other Small Shelves\n'4' to Check the other Work Benches\n'5' to Check the Room\n'6' to Leave the Room through either Door\n'0' to Quit the Program");

        var btwChoice = Int32.Parse(Console.ReadLine());

        switch (btwChoice)
        {
            case 1:
                //Orb box
                WriteLine("Code is coming!");
                break;
            case 2:
                //Manual: Door needs Key to unlock, Orb and Locket to Activate Protection
                WriteLine("Code is coming!");
                break;
            case 3:
                //shelves - nothing
                WriteLine("Code is coming!");
                break;
            case 4:
                //work benches - code on paper, drawings?
                WriteLine("Code is coming!");
                break;
            case 5:
                //notice glyphs on wall
                WriteLine("Code is coming!");
                break;
            case 6:
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
        WriteLine("Code is coming!");
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