// encounters
using System;
using static System.Console;
using static System.Math;

class Encounters
{
    public static void hallCloset2()
    {
        //reuse code from original
        // initializing variables for the encounter
        int playerRoll = 0;
        int closetRoll = 0;
        var rand = new Random();

        Console.WriteLine("As you open the closet door, you see a ghostly hand reach for you!");
        Console.WriteLine("Pick a number between 1 and 20, to see if you dodge the hand...: ");
        playerRoll = Int32.Parse(Console.ReadLine());
        closetRoll = 5 + rand.Next(1, 21);       // SHOULD generate a random integer between 1 and 20

        if(playerRoll > closetRoll)
        {
            Encounters.handSurvived();
        } else if((playerRoll - closetRoll) <= -5) {
            Encounters.handDeath();
        } else {
            Encounters.handPassedThrough();
        }

    }

    public static void handDeath()
    {
        Console.WriteLine("You try to dodge the hand but it is too quick. It latches onto your face. Black, smoky tendrils erupt from the hand and wrap around your head. You sink to the ground as your life essence is drained away. You hear a deep, sinister laughter accompanying you into darkness....");
        System.Environment.Exit(0);    // is this right?
    }
    public static void handPassedThrough()
    {
        Console.WriteLine("The hand reaches for your chest... and passes through it. There were no physical effects but you are pretty shaken up. You hear, in the distance, a low, ominous chuckle. You continue on.");
        Console.WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();
        HouseFirst.FrontHouse.hallway();
    }
    public static void handSurvived()
    {
        Console.WriteLine("The hand reaches for you... but you manage to dodge to one side. It passes through the wall of the hallway, and disappears. You hear a short but low chuckle from... somewhere. You decide to continue with the hall... ");
        Console.WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();
        HouseFirst.FrontHouse.hallway();
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
        System.Environment.Exit(0);  
    }

    public static void ghoulRun()
    {
        WriteLine("You see something that shouldn't be REAL and definitely shouldn't be standing in front of you... so you decide to run!");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();

        WriteLine("You run around the side of the house, towards the front porch. You hear the Ghoul shuffling after you but you can't tell how close it is.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();

        WriteLine("You arrive back in the front yard. Your car is parked nearby; the front door of the house is also close.\nWhat do you want to do?");
        WriteLine("\nEnter '1' to Run back to the House\nEnter '2' to Run to your Car\nEnter '3' to keep running\nEnter '0' to quit the program");

        var chaseChoice = Int32.Parse(Console.ReadLine());

        switch (chaseChoice)
        {
            case 1:
                //back into the house
                WriteLine("You sprint towards the front porch.\nYou stop in the Entry, trying to slow your rapidly beating heart and fast breathing.");
                WriteLine("Press 'Enter' to continue.");

                WriteLine("You poke your head back out the door... and do not see the Ghoul in sight.\nYou close the door, hesitate, then go back to searching the house.");
                WriteLine("You return to the Living Room. Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                HouseFirst.FrontHouse.livingRoom();
                break;
            case 2:
                //to the car
                break;
            case 3:
                //keep running - ghoul stops
                WriteLine("You keep running, ignoring your car AND the House.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();

                WriteLine("You run across the street and head towards an open cafe.\nYou enter, slightly startling a waitress. You compose yourself - while glancing outside for pursuit- and taker a seat.\n\nYou do not see any sign of the Ghoul but that only slightly eases your fears.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();

                WriteLine("You put off your search of the Adams Manor.\nYou need to do a whole lot more research on the Manor, more than what you did in preparation for this first search.\nYou also decide to see what can slow or stop a Ghoul.\nFor now, you enjoy the recently-arrived coffee and plan your next steps.");
                System.Environment.Exit(0);
                break;        

            case 0: default:
                WriteLine("You have exited the program.");
                break;
        }

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
                playerDead();
            if(ghoulHealth <= 0)
                ghoulDead();     
                
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
        WriteLine("You fall to the ground after the Ghoul's latest claw swipe. You have been cut and slashed in many places, some of the slashes really deep.\nYou try to crawl away but the Ghoul stops you. It licks you up by the back of your shirt and tosses you into the tree line.\nYou black out as you impact a particularly large tree.\n You don't see or feel it - thankfully - when the Ghoul reaches you body and chomps down on your torso.");
        System.Environment.Exit(0); 
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