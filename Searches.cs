//Searches

using System;
using System.Text;
using static System.Console;

class ItemSearches
{
    public static void nothing()
    {
        WriteLine("You find nothing of interest. Press 'Enter' to continue.");
        Console.ReadLine();
    }
    
    public static void studyBookcases()
    {
        WriteLine("You check the full bookcases. Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();

        // add Dictionary, text
    }

    public static void couch()
    {
        WriteLine("You head over to the Couch. Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();

        WriteLine("You do not see anything on or around the Couch. As you check under the cushions, you see a small metal object in the corner of the couch. You grab it and pull it out. Press 'Enter' to continue.");
        Console.ReadLine();

        WriteLine("You find the LOCKET.");
        WriteLine("It is round, silver pendant on a thin, silver-colored chain. You open the pendant and see a picture of a couple. There is a tall, red-haired woman, sitting in a leather chair. She is wearing a stylish, emerald-colored dress with blue trim. She has a friendly face and a large, warm smile.\nStanding behind her is a tall man with long, salt-and-pepper hair. He is wearing a dark blue suit. He has an almost cheesy grin on his face.");
        WriteLine("On the back of the pendant, there is an inscription: \n'RJ + MJ - Love Shields From The Dark'\n");
        WriteLine("You put the LOCKET around your neck and continue in the Living Room.");
        WriteLine("Press 'Enter' to continue.");

        Console.ReadLine();
        Console.Clear();
        HouseFirst.FrontHouse.livingRoom();

    }

}