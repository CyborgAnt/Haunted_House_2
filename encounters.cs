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

                WriteLine("Dazed, you hurry to your feet. Standing near you is... something not human.\nFor starters, its arms are entirely too long and end in a set of claws.\nThe body is compact but still well over 5 feet tall, with tattered remains of clothes clovering it.\nThe head is humanoid but the mouth is full of sharp, canine-like teeth. It's eyes are cunning, lacking remorse.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
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
        WriteLine("Unfortunately, you do not make it THROUGH the window.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();

        WriteLine("The Ghoul reaches out for you again.\nHowever, the claws don't grab your shoulders: they go through your back and out through your chest.");
        WriteLine("There is a sharp pain... then a numbness. You are left wondering why there is a Ghoul in the yard, in the first place, as your consciousness fades to black....");
        System.Environment.Exit(0);  
    }

    public static void ghoulRun()
    {
        WriteLine("You see something that shouldn't be REAL and definitely shouldn't be standing in front of you... so you decide to run!");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();

        WriteLine("You run around the side of the house, towards the front porch.\nYou hear the Ghoul shuffling after you but you can't tell how close it is.");
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

                WriteLine("You poke your head back out the door... and do not see the Ghoul at all.\nYou close the door, hesitate, then go back to searching the house.");
                WriteLine("You return to the Living Room. Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                HouseFirst.FrontHouse.livingRoom();
                break;
            case 2:
                //to the car
                WriteLine("You decide to make a run for you car.\nYou sprint towards the driver's side door, yank it open, and dive inside. You sit up, start the car, and look out the windshield.\nThe Ghoul is shambling towards the car, although it's not terribly choice.\n\nWhat do you do? Press 'Enter to Continue.");

                Console.ReadLine();
                WriteLine("'1' to Drive Away'\n'2' to Attempt to Run Over the Ghoul\n");

                var carChoice = Int32.Parse(Console.ReadLine());
                switch (carChoice)
                {
                    case 1:
                        //Drive Away
                        WriteLine("You have had enough. Seeing a Ghoul - WHICH SHOULD NOT BE REAL - is more than you signed up for. Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();

                        WriteLine("As the Ghoul shambles closer, you start your car, put it in Reverse, and peel out.\nYou shift into Drive and roar away from the Adams Manor. You realize that you didn't find a definitive, explanable answer for the sights and noises at the Manor... key word being 'explanable'.");
                        WriteLine("Nevertheless, you are alive. As you drive back to your office, you comtemplate going back to the Adams Manor in the future... and going back during the day.");
                        System.Environment.Exit(0);
                        break;
                    case 2:
                        //Run Over
                        WriteLine("The Ghoul still shambles forward, but it has slowed down.\nYou decide to ram it with your car! Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();

                        WriteLine("You floor the gas pedal, lining up the Ghoul. The impact is bone-jarring!\n");
                        WriteLine("The impact throws you into the steering wheel, knocking the wind out of you. The Ghoul is knocked many feet backwards, landing with a loud 'Thud!'.\nIt lies, unmoving, near the front porch. Press 'Enter' to continue.");

                        Console.ReadLine();
                        Console.Clear();
                        WriteLine("You examine the body of the Ghoul. There are no discerning features on the body, such as scars.\nYou check the tattered clothing and find a wallet and some keys.\nInside the wallet, you find some cash, some random business cards, and an ID: \n\nBilly Adams\n10 Primrose Way\nAge: 21");
                        WriteLine("You take the walley and keys and go back into the Manor.\n");
                        HouseFirst.FrontHouse.entryway();

                        break;
                    default:
                        WriteLine("You have exited the program.");
                        break;
                }
                break;
            case 3:
                //keep running - ghoul stops
                WriteLine("You keep running, ignoring your car AND the House.");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();

                WriteLine("You run across and down the street, towards an open cafe.\nYou enter, slightly startling a waitress. You compose yourself - while glancing outside for pursuit- and taker a seat.\n\nYou do not see any sign of the Ghoul but that only slightly eases your fears.");
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
        WriteLine("\nYou pull your gun, ready to defend yourself from this creature...\n");

        WriteLine("'In this encounter, you and the Ghoul will take turns attacking each other (you with 'Shoot', the Ghoul with 'Claw'). You and the Ghoul also have hidden armor values.\nA random-generated number, from 1-20, is used for the attack value, simulating a 20-sided dice roll.\nIf your attack value is greater than or equal to the other's armor, you make a succesful attack and deal damage.\nThe first one to bring their opponent's health to 0 (or less) wins!'\n\nPress 'Enter' to continue.");
        Console.ReadLine();

        //variables for the encounter
        var playerArmor = 10;
        var ghoulArmor = 12;
        var playerHealth = 40;
        var ghoulHealth = 30;
        // add code for when the player runs out of bullets?
        
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
            int damage = dmg.Next(1,9);     // 1-8 points of damage per shot

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
            int ghoulDmg = dmgg.Next(2,9);     // 2-8 points of damage per attack

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
        WriteLine("You fall to the ground after the Ghoul's latest claw attack.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();
        
        WriteLine("You have been cut and slashed in many places, some of the slashes really deep.\nYou try to crawl away but the Ghoul stops you. It picks you up by the back of your shirt and tosses you into the tree line.\nYou black out as you impact a particularly large tree.\n You don't see or feel it - thankfully - when the Ghoul reaches you body and chomps down on your torso.");
        System.Environment.Exit(0); 
    }

    public static void ghoulDead()
    {
        WriteLine("With that final shot, the Ghoul slows down, stops, and falls over, dead - again. Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();

        WriteLine("You examine the body of the Ghoul. There are no discerning features on the body.\nYou check the clothing and find a wallet and some keys.\nInside the wallet, you find some cash, some random business cards, and an ID: \n\nBilly Adams\n10 Primrose Way\nAge: 21");
        WriteLine("Press 'Enter' to continue.");

        WriteLine("You take a few moments to steady yourself.\nYou then head back to the window that you were unceremoniously yanked out of, and climb back in.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();
        Console.Clear();
        HouseFirst.FrontHouse.livingRoom();

    }

    public static void grid()
    {
        string gridCode = 'QT97';       //may have to edit this formatting
        WriteLine("Starting with the first tile you step on, enter the 4-tile path you take:");
        var path = Console.ReadLine();
        if(gridCode == path)
        {
            WriteLine("You step on the center tile and it glows a mellow green color.\nThe rest of the tiles glow green, then go out; it feels like the grid is now safe to walk on.\nSuddenly, the statue turns towards you!\nThe box that it is holding unfolds flat; resting on top of the now-flat box is a GREEN ORB.\n On one of the sides of the box is a number:\n'729'.\nYou take the GREEN ORB, jot down the number on a piece of paper, and leave the room.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            SecondFloorRooms.stairs();
        }
        else
        {
            WriteLine("You step on the center tile to complete the 'path'. Nothing happens, at first.\nPress 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            WriteLine("Suddenly, the center tile glows a bright red. At nearly the same time, the Statue turns towards you and opens its mouth!\nA glow begins to eminate from the mouth; you run towards the door...");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            WriteLine("Before you can reach the door, a huge blast of heat, fire, and light hits you squarely in the back.\nThe blast is tremendous; it launches you several feet in the air and propels you several feet forward, smacking the outside hall with a jarring thud.\n");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            WriteLine("You nearly black out from the blast and the impact in the hall.\nYou hear a grinding sound; you see the Statue now at the doorway!\nYou start scrambling away, heading towards the stairs. You reach the stairs... and are hit by a 2nd blast, as the Statue could still see you.\n\nYou survived the 1st blast; you do not survive the second, as you are launched down the stairs, into the living room, in a smouldering heap.");
            System.Environment.Exit(0);
        }
    }

    public static void diary()
    {
        WriteLine("The opening passages are mundane, day-to-day writing about Rosella and Billy Adams, presumably the wife and son of the writer.");
        WriteLine("You then see a few writings that catch your eye:");
        WriteLine("'Dec. 1st\nRos has dived deep into the occult. At first, I thought it was just one of her many fancies but she has begun researching everything from The Power of Moonlight to Glyphs.'");
        WriteLine("'Dec. 7th\nRos and Billy have spent a lot of time on occult websites, by his admission. He asked if I knew about 'Spirit Capturing' - of course not! He shrugged, said it's fascinating, and went back to the Office.'\n'Dec. 11 - Ros looks... haggard? Tired? She still has her dazzling smile but she looks drained.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();

        WriteLine("Dec. 26 - Billy and Ros have begun reorganizing the extra room in the basement, behind the Entertainment Room. When I asked about it, Ros just said 'You will see soon' and shooed me away.\nShe has also been acting more... aggressive, lately: not malicious, but quick to snap a reply to something, easy to anger, although not by me or Billy.\nI don't like it.\n");
        WriteLine("Jan. 10 - Billy is ill, possibly the flu. He spends almost all of his time either in the basement or on the Office computer.\nRos ordered some kind of metal door for the basement, called The Gate. Saw the email on the Office computer.");
        WriteLine("Jan. 16 - The Gate arrived. It is a huge metal door with slots for something to go in. Ros seemed pleased... and worried?\nA group of Electricians arrived around noon, to presumably wire 'The Gate'. That's it! Ros and I need to talk!\n");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();

        WriteLine("You skip some grumblings about Electricians.");
        WriteLine("Jan. 16 - Two things: Billy is very ill and Ros has changed for the worst.\nI confronted her about The Gate, the fact that Billy is sick, and her sudden obsession with the occult.\nHer reesponse? She roared at me! Like, 'Grizzly Bear' roared! She started screaming about 'being a powerless swine' and actually took a swing at me!\nWhat made this so bad: her eyes. They looked... evil. And... cunning. She went outside to meet the electricians; I didn't see or hear from her for the better part of 2 days.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();

        WriteLine("Jan. 20 - we rushed Billy to the hospital. He came upstairs, greeted me, took a couple of steps, and collapsed.");
        WriteLine("Jan. 21\nMy son, a healthy 21 year old less than a month ago, is dead. Doctors said 'Heart Failure' but they didn't sound convinced.\nRos hugged me, then said that she wanted to 'claim the body'. I tried to stop her, saying that this is no time for morbid occult crap; she responded that 'you don't want to get in my way, Richard.' Again, those cunning, malevolent eye flashes.\n");

        WriteLine("Jan. 23 - the local funeral home has Billy's body, after some kind of arrangement with the hospital and Ros. Ros has spent as much time there as she has spent here.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();

        WriteLine("Jan. 26\nRos said that she has to spend a couple of nights 'behind The Gate'; she would not elaborate. I agreed, kissed her, followed her to the basement, and watched as she closed The Gate.\nI then went upstairs to the Office and tried to see what she and Billy might have been researching.\nI saw that one of them had been looking heavy into using spirits to gain power?? That had to be Ros!\nHowever, one of the pages said that 'if you attempt the calling and you are not of sound mind and spirit, you could end up cursed or spiritually drained.'\nIs this what happened to Billy? And what has happened to Ros? I'm going to open The Gate!");

        WriteLine("I opened the gate. It will be the last mistake of my life.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();

        WriteLine("What I saw when I opened the gate... impossible. Except, I SAW IT. It was Ros, but changing into... something dog-like, wolf-like. She had her back to me but KNEW I WAS THERE. She turned to me... oh man, she LOOKED AT ME. 'I went too deep and now I'm changed... for the better', she said.\n'I can take what I want, when I want. I can bring Billy back. And I will rule the creatures of the night!'\nShe then SMILED AT ME... and lunged.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();

        WriteLine("The next thing I know, I'm thrown all the way back to the stairs, bleeding everywhere.\nI crawl up the stairs to the Kitchen; as I go, I hear her say: 'Richard, I love you, which is why I didn't devour you. Go hide somewhere, until the full moon is passed. If you stay down here, I can't control what will happen.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();

        WriteLine("The final entries are in a shaky hand.\n'I looked at the computer, on the way to a hiding place.\nI now know what happened to Ros.\nShe was Cursed.\nShe has become the worst form of a Lycanthrope: the Loup-Garou.\nShe can't be harmed, except by silver. She is stronger, faster, and more cunning, and she will now suffer from a bloodlust that is almost impossible to control.");
        WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();
        
        WriteLine("And she knew this would happen... which is why she ordered The Gate. The Gate will help contain her when the Full Moon is her and she starts changing.\n\nI have a little bit of time left. I'm going to use those glyphs I saw on another page and draw them everywhere possible!");
        WriteLine("I am hiding in the Wardrobe upstairs. I think it's the 28th.\nI heard her scream when she opened The Gate; maybe the glyphs work.\nRegardless, I'm too wounded to check and see. Whoever finds this diary, she is no longer human. On the Full Moon, if she's not in the basement, she will kill everyone near this house.");

    }

}