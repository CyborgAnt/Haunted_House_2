// encounters
using System;
using static System.Console;

class Encounters
{
    public static void hand()
    {
        //need to be 'Public'?

    }    

    public static void hallCloset2()
    {
        //reuse code from original

    }

    public static void window2()
    {
        //in Living Room; yanked out - random numbers?
        WriteLine("You walk over to the far window and peer outside. It is dusk, so it's hard to make out a lot of items, but you do see a line of trees about 2-3 dozen feet away.");
        WriteLine("Do you open the window to get a better view?\n");
        WriteLine("Enter 'Y' or 'y' to open the window\nEnter 'N' or 'n' to leave the Window closed");

        var window = Console.Read();        // can I use Read()?
        
        switch (window)
        {
            case 'Y': case 'y':
                //nothing happens
                WriteLine("You open up the window.\nThere is a cool, refreshing breeze that brushes your face. Other than that, nothing unusual happens.\nYou close the window.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                HouseFirst.FrontHouse.livingRoom();
                break;
            case 'N': case 'n':
                //code - snatched?!
                WriteLine("You leave the window shut. Press 'Enter' to continue.");
                break;
            
            default:
                WriteLine("You have exited the program.");
                break;
        }


    }

}