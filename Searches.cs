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
    
    /* public static void studyBookcases()
    {
        WriteLine("You check the full bookcases. Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();

        WriteLine("There is an almost mind-numbing number and variety of books on these bookcases.\nA couple of titles catch your eye:\n'Silver' by John Peterson\n'Protection Glyphs' by Josie Chaldera\n");
        WriteLine("'Protection Glyphs' is a magazine - who publishes magazines like this? - about using Glyphs as shields and containments, how to draw them, and what materials to use when drawing them.\nOne of the glyphs described is of a triangle; at each point of the triangle, a circle is drawn around them, in red, blue, and green.\nThis Glyph is used to hold a spirit, demon, or creature within a certain area, as well as weaken it.");
        WriteLine("Press 'Enter' to continue.");
<<<<<<< HEAD
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
        }     

    } */
=======
        Console.ReadLine();
        Console.Clear();

        WriteLine("'Silver' is more of a scientific article than a book.");
        WriteLine("It describes the power of silver, especially when involving the supernatural.\nIt can be used in weapons, shields, and even potions to ward one's spirit.");
        WriteLine("A short but interesting article. You place it back on the bookcase and decid what to do next.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();
        FirstFloor.FrontHouse.studyChoose();
    }
>>>>>>> 674ca06c0546495661639bb03c76af50037380d7

    public static void couch()
    {
        WriteLine("You head over to the Couch. Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();

        WriteLine("There is nothing on or around the Couch.\nAs you check under the cushions, you see a small metal object in the corner of the couch. You grab it and pull it out. Press 'Enter' to continue.");
        Console.ReadLine();

        WriteLine("You find the LOCKET.");
        WriteLine("It is a round, silver pendant on a thin, silver-colored chain. You open the pendant and see a picture of a couple.\nThere is a tall, red-haired woman, sitting in a leather chair. She is wearing a stylish, emerald-colored dress with blue trim. She has a friendly face and a large, warm smile.\nStanding behind her is a tall man with long, salt-and-pepper hair. He is wearing a dark blue suit. He has an almost cheesy grin on his face.");
        WriteLine("On the back of the pendant, there is an inscription: \n'RA + MA - Love Shields Us From The Dark'\n");
        WriteLine("You put the LOCKET around your neck and continue in the Living Room.");
        WriteLine("Press 'Enter' to continue.");

        Console.ReadLine();
        Console.Clear();
        FirstFloor.FrontHouse.lvrChoose();

    }

    public static void safe()
    {
        WriteLine("You take a closer look at the safe. Under the numerical keypad, there is a hand-written strip of paper: 'You only get 3 chances'.");
        WriteLine("Do you try to enter the code?");
        WriteLine("1. Yes, 2. No");
        int safeOpen = Int32.Parse(ReadLine());
                    
        switch (safeOpen)
        {
            case 1:
                WriteLine("You decide to try and open the safe.");

                 // variables
                int attemptsLeft = 3;       // number of attempts to open the safe
                int safeCode = 7521;
                int enteredCode = 0;    // initialized

                while(attemptsLeft > 0)
                {
                    WriteLine("Enter the 4-digit code: ");
                    enteredCode = Int32.Parse(ReadLine());
                    if(enteredCode != safeCode)
                    {
                        WriteLine("Incorrect!");
                        attemptsLeft -= 1;
                        WriteLine("{0} attempts left.", attemptsLeft);
                        if(attemptsLeft == 0)
                        {
                            WriteLine("You have tried to open the safe 3 times and failed. As you start to turn around to leave, you feel several sharp, piercing points go into your back and side. On the opposite side of the room, 4 small openings are now evident on the wall. You almost immediately feel dizzy and heavy-limbed. You've been drugged or poisoned!");
                            WriteLine("You collapse to the ground, consciousness slipping away. You are still alive but you will be out of commission for quite awhile, as the sleeping poison works its way through your system. You hope that 'she' doesn't find you before you wake up....");

                            // 'end program' code
                        }
                    }
                    if(enteredCode == safeCode)
                    {
                        WriteLine("Correct!");

                        WriteLine("\nThe internal lock of the safe clicks open. You open the door and see 3 items: a folded piece of paper, a newspaper clip, and a large, sliver-plated GUN.");
                        WriteLine("More code to come!");
                    }
                }
                break;    
        
            case 2:
                WriteLine("You don't want to risk trying to open the safe.\n You return to the search....");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                break;
            default:
                WriteLine("You have exited the Program.");
                System.Environment.Exit(0);
                break; 
            
        }
    }
}