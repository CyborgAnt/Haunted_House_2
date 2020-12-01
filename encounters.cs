// encounters
using System;
using static System.Console;
using static System.Math;

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
                Console.ReadLine();
                Console.Clear();

                WriteLine("As you turn away from the window, you suddenly hear a loud roar from outside, and the window shatters!!");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();

                WriteLine("Two massive, hairy claws grab you by the shoulders! You struggle to free yourself but cannot break the grip. You are then yanked through the broken remains of the window, into the yard outside.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();

                WriteLine("Dazed, you hurry to your feet. Standing near you is... something not human. For starters, it's arms are entirely too long and end in a set of claws. The body is compact but still well over 5 feet tall, with tattered remains of clothes clovering it.\nThe head is humanoid but the mouth is full of sharp, canine-like teeth. It's eyes are cunning lacking remorse.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                WriteLine("What yanked you out of the window is something you've only seen in movies: a Ghoul!\n");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                WriteLine("What do you do next?");
                WriteLine("Enter '1' to Run!\nEnter '2' to Shoot it!\nEnter '3' to Climb back through the window");

                var ghoulChoice = Int32.Parse(Console.ReadLine());

                switch (ghoulChoice)
                {
                    case 1:
                        // run - ghoulRun(), new story branch?
                        ghoulRun();
                        break;
                    case 2:
                        // shoot - ghoulShoot(); mini-version of boss fight
                        ghoulShoot();
                        break;
                    case 3:
                        // ghoulEnd() - 'bad'
                        ghoulEnd();
                        break;       

                    default:
                        WriteLine("You have exited the program.");
                        break;
                }
                break;
            
            default:
                WriteLine("You have exited the program.");
                break;
        }

    }

    public static void ghoulEnd()
    {
        Console.Clear();
        WriteLine("You see this... creature... and want to get far away from it.\nYou decide to try and go around it, heading back to the window.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();

        WriteLine("You sidestep the Ghoul and make it to window.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();

        WriteLine("Unfortunately, you do not make it THROUGH the window.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();

        WriteLine("The Ghoul reaches out for you again. However, the claws don't grab your shoulders:\nThey go through your back and out through your chest.");
        WriteLine("There is a sharp pain... then a numbness. You are left wondering why there is a Ghoul in the yard, in the first place, as your consciousness fades to black....");
        
    }

    public static void ghoulRun()
    {

    }

    public static void ghoulShoot()
    {
        Console.Clear();
        WriteLine("'In this encounter, you and the Ghoul have hidden armor values.\nYou both also have attacks ('Shoot' for you, 'Claw' for the Ghoul); a random-generated number, from 1-20, is used for the attack value.\nIf your attack value is greater than or equal to the other's armor, you make a succesful attack and deal damage. The first one to bring their opponent's health to 0 (or less) wins!'\n\nPress 'Enter' to continue.");
        Console.ReadLine();

        //variables for the encounter
        var playerArmor = 10;
        var ghoulArmor = 12;
        var playerHealth = 40;
        var ghoulHealth = 30;
        // add code for when the player runs out of bullets
        
         while((ghoulHealth> 0) || (playerHealth > 0))
        { 
            if(playerHealth <= 0)
                    //playerDead();
            if(ghoulHealth <= 0)
                    //ghoulDead();     
                
            Console.WriteLine("You have {0} Hit Points, while the Ghoul has {1} Hit Points.", playerHealth, ghoulHealth);
                
            Console.WriteLine("You fire off a shot…");
                
            // for the player
            Random rd = new Random();
            int roll = rd.Next(1, 21);      // simulating a 20-sided die roll
            Random dmg = new Random();
            int damage = dmg.Next(1,7);     // 1-6 points of damage per shot

            if(roll >= ghoulArmor)
            {		
                WriteLine("Hit! You do {0} points of damage!", damage);
                ghoulHealth -= damage;
                WriteLine("It now has {0} Hit Points", ghoulHealth);
            }
            else
            {
                WriteLine("Miss!");
            }
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();

            WriteLine("The Ghoul attacks with its claws…");

            // for the Ghoul
            Random rl = new Random();
            int rollG = rl.Next(1, 21);
            Random dmgg = new Random();
            int ghoulDmg = dmgg.Next(1,9);     // 1-8 points of damage per attack

            if(rollG >= playerArmor)
            {
                WriteLine("Hit! It does {0} points of damage!", ghoulDmg);
                playerHealth -= ghoulDmg;
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

    public static void playerDead()
    {
        WriteLine("You fall to the ground after the Ghoul's latest claw swipe. You have been cut and slashed in many places, some of the slashes really deep.\nYou try to crawl away but the Ghoul stops you. It licks you up by the back of your shirt and tosses you into the tree line.\You black out as you impact a particularly large tree.\n You don't see or feel it - thankfully - when the Ghoul reaches you body and chomps down on your torso.");
    }

    public static void ghoulDead()
    {
        WriteLine("With that final shot, the Ghoul slows down, stops, and falls over, dead - again. Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();

        WriteLine("You examine the body of the Ghoul. There are no discerning features on the body.\nYou check the clothing and find a wallet and some keys.\nInside the wallet, you find some cash, some random business cards, and an ID: \n\nBilly Adams\n10 Primrose Way\nAge: 21");
        WriteLine("Press 'Enter' to continue.");

        bool wallet = true;     // player found the wallet; useful in next-to-last room

        WriteLine("You take a few moments to steady yourself.\nYou then head back to the window that you were unceremoniously yanked out of, and climb back in.");
        HouseFirst.FrontHouse.livingRoom();

        Console.ReadLine();
        Console.Clear();

    }
}