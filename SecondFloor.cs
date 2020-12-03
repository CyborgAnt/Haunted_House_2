//second floor
//intro code

class SecondFloor
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
        WriteLine("'1' to take the Left Hall and check the Closest Door\n'2' to take the Left Hall and check the Farthest Door\n'3' to take the Left Hall but skip both doors\n'4' to take the Right Hall and check the Closest Door\n'6' to take the Right Hall but Skip the Closest Door\n'7' to go back down the Stairs\n'0' to Quit the Program");
        var upperStairsChoice = Int32.Parse(Console.ReadLine());

        switch (upperStairsChoice)
        {
            


            default:
        }
    }

    public static void bedroom2()
    {
        //Statue-puzzle
        WriteLine("Code coming soon!");
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
        WriteLine("Code coming soon!");
    }

    public static void behindTheWalls()
    {
        //code on wall; wires; info about Orb, Locket
        WriteLine("Code coming soon!");
    }
}
