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

        WriteLine("There is an almost mind-numbing number and variety of books on these bookcases.\nA couple of titles catch your eye:\n'Silver' by John Peterson\n'Protection Glyphs' by Josie Chaldera\n");
        WriteLine("'Protection Glyphs' is a magazine - who publishes magazines like this? - about using Glyphs as shields and containments, how to draw them, and what materials to use when drawing them.\nOne of the glyphs described is of a triangle; at each point of the triangle, a circle is drawn around them, in red, blue, and green.\nThis Glyph is used to hold a spirit, demon, or creature within a certain area, as well as weaken it.");
        WriteLine("Press 'Enter' to continue.");
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