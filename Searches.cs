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

        WriteLine("There is an almost mind-numbing number and variety of books on these bookcases. You browse through the titles and start picking out some that catch your attention: ");
        /* add Dictionary, text
        var books = new Dictionary<string, string>()
        {
            {"1 Anthony Brennen","Demon Summoning"}, 
            {"2 Josie Chaldera","Glyphs, Issue 3: 'Protection Glyphs'"},
            {"3 Taryn Lee","The Power of the Full and New Moons"},
            {"4 John Peterson","Silver"}
        };

        foreach(var kvp in books)
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine(); 

        WriteLine("Type in the number in front of the author name to choose a book: ");
        var author = Int32.Parse(Console.ReadLine());

        switch(author)
        {
            case 1:
            {
                WriteLine("You chose 'Demon Summoning' by Anthony Brennen.");
                WriteLine("It is a journal-sized book, maybe 20 pages. As you skim through it, you see that it mainly deals with the details of summoning. Of particular interest are passages that deal with 2 dangers of failed summons.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                WriteLine("To summorize: 1. If the demon refuses to respond, it can cast a Curse back at the summoner, causing them to become a human-monster hybrid. 2. The demon can also attempt to possess, or outright kill, the summoner, if the summoner is weak of mind or will.");
                WriteLine("You return this disturbing book back to the shelf and leave the bookcase.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                den();
                break;
            }    
            case 2:
                WriteLine("You choose 'Protection Glyphs' by Josie Chaldera.");
                WriteLine("This is a magazine - who publishes magazines like this? - about using Glyphs as shields and containments, how to draw them, and what materials to use when drawing them.\nOne of the glyphs described is of a triangle. At each point of the triangle, a circle is drawn around then. Surrounding the whole figure is a larger circle. This Glyph is used to hold a spirit, demon, or creature within a certain area.");
                WriteLine("You take a mental note of that glyph and put the book back.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                den();
                break;
            case 3:
                WriteLine("The book by Taryn Lee details the known - and unknown - powers of the different phases of the moon. The Full Moon and various shapeshifters - like Werewolves - are listed in the 'known powers' section. But there is a mention of something called a 'Loup-Garou'. It is basically described as a demonic version of a 'super werewolf'?!?");
                WriteLine("As your blood freezes, you shove that book back onto the shelf.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                den();
                break;
            case 4:
                WriteLine("John Peterson's book, 'Silver', is more of a scientific article than a book.");
                WriteLine("It describes the power of silver, especially when involving the supernatural. It can be used in weapons, shields, and even potions to ward one's spirit.");
                WriteLine("A short but interesting article. You place it back on the bookcase.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                den();
                break;
            default:
                WriteLine("You have exited the program.");
                return;    
        }  */    

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