using System;

namespace Interactive_story
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ett försök på Suderduper svåra :
            Console.WriteLine("Hello and welcome to an interactive story!\nWhen there is 'Dark Gray' color you are supposed to press a key or type text!");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Press any key to start!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            introduction(); //the introduction is only executed once
        }

        static void introduction() //start the story
        {
            Console.WriteLine("You wake up and feel a weird feeling in your head. Usually you go to bed again when it happens.\nBut this time you decide to not try and sleep again.\nJust as you stand up you hear the alarm sound from your phone.\nYou feel lucky that you woke up by yourself even though the headache is still present.");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("(press any key to continue)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            bedroom("first"); //starts the first interaction with the user in the bedroom, shown with the "first" tag
        }

        static void bedroom(string specialOccasions)
        {
            switch (specialOccasions)
            {
                //'case "first":' is the first question to the user. 
                case "first":
                    string temp = "";
                    Console.WriteLine("As you take your first steps for the day you walk to the wardrobe to take on your clothes.\nYou feel a punch in your stomach, but it wasn't a punch.\nYou realise it is your stomach saying you need to go to the toilet, but you almost refuse the instinct.");
                    while (temp != "toilet" && temp != "kitchen")
                    {
                        Console.WriteLine("Will you go to the kitchen as your normal routine or go to the toilet?");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("(kitchen/toilet)");
                        Console.ForegroundColor = ConsoleColor.White;
                        temp = Console.ReadLine().ToLower();
                    }
                    if (temp == "kitchen") //you chose to drik coffe
                    {
                        kitchen("first");
                    }
                    else //it should be that you chosed the toilet, but else includes all but "kitchen".... also makes it failsafe
                    {
                        toilet("first");
                    }
                    break;

                case "sleepyMorning":
                    Console.WriteLine("You enter the bedroom, nothing feels out of place.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("But you have become really sleepy after this crazy morning!");
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Not realising it you have crept up in the bed under the cover again. You feel cold.");
                    System.Threading.Thread.Sleep(2000); //The console.beep does not work :(, but i manage. at least it is there
                    Console.Beep(800, 250);
                    Console.WriteLine("BEEP!");
                    System.Threading.Thread.Sleep(500);
                    Console.Beep(800, 250);
                    Console.WriteLine("BEEP!");
                    System.Threading.Thread.Sleep(500);
                    Console.Beep(800, 250);
                    Console.WriteLine("BEEP!");
                    Console.WriteLine("You have officially missed work.... Your boss WILL fire you! (ending 3/3)");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("You enter the bedroom, nothing feels out of place.");
                    navigate("bedroom");
                    break;
            }
        }

        static void kitchen(string specialOccasions)
        {
            switch (specialOccasions)
            {
                case "first":
                    string temp = "";
                    Console.WriteLine("You decide it is best to do your daily routine, a cup of coffe and something from the pantry.\nTodays menu got to be some white bread with some dark coffe, you never really liked milk anyways...\nBut you feel that it might be nice to test again?");
                    while (temp != "y" && temp != "n")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Will you put milk in your coffe this time? (y/n)");
                        Console.ForegroundColor = ConsoleColor.White;
                        temp = Console.ReadLine();
                    }
                    if (temp == "y")
                    {
                        Console.WriteLine("It does indeed taste good! But you reccon it could taste better...\nYou decide to take some slurps to be able and add more milk.");
                        toilet("milkyDeath");
                    }
                    else
                    {
                        Console.WriteLine("Maybe keeping it normal is a good idea afterall.\nBut you realise the routine has already taken over and that you are not adding any milk, just sugar.\nA thought strikes you, 'Oh that is right: I'm are lactose intolerant....' You would NOT have wanted it with milk!");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("(press any key to continue)");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        toilet("afterBreakfast");
                    }

                    break;
                case "":
                    Console.WriteLine("You enter the kitchen, nothing feels out of place.");
                    navigate("kitchen");
                    break;


            }
        }


        static void toilet(string specialOccasions)
        {
            switch (specialOccasions)
            {
                case "first":
                    Console.WriteLine("You have now entered the bathroom.\nIt feels really good to let go of everything that pained you earlier.");
                    System.Threading.Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You blink and the blinks are extremely heavy.");
                    System.Threading.Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("This time it hurts, you even decide to close your eyes and count to 1, 2, 3, 4.....");
                    System.Threading.Thread.Sleep(4000); //You supposedly counted to 4 :)
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You finally come back to reality. You look at the clock and realise you are late to work.\nYou really should have choosen to stick to your routine and not freestyle it...\nYou came a bit late to work but survived! (ending 1/3)");
                    Console.ReadKey();
                    break;

                case "milkyDeath":
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("But as you drank the last of your coffe with milk, your stomach hurt even more.");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("You end up in the bathroom hoping for the best...");
                    Console.Write("But, it only got ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("W ");
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("O ");
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("R ");
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("S ");
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("E ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You had forgot your lactose intolerance and died the milky way! (ending 2/3)");
                    Console.ReadKey();
                    break;
                case "afterBreakfast":
                    Console.WriteLine("You finally completed the breakfast and ended up in the bathroom.");
                    Console.WriteLine("The coffe and bread made the worst pain fade away.\nDon't get it wrong as you are still happy to be where you are.\nBut the coffe didn't have the usual streangth to it and you still feel really sleepy.\nYou feel that something is missing and start to navigate the house!");
                    navigate("bathroom");
                    break;
                case "":
                    Console.WriteLine("You enter the bathroom, nothing feels out of place.");
                    navigate("bathroom"); //bathroom is exception because we want it to say "in the bathroom" and not "in the toilet"
                    break;

            }
        }
        static void navigate(string position)
        {
            Console.WriteLine($"You are in the {position}, where do you want to go?");
            switch (position)
            {
                case "kitchen":
                    string warpTo = "";
                    while (warpTo != "bedroom" && warpTo != "toilet")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("(bedroom/toilet)");
                        Console.ForegroundColor = ConsoleColor.White;
                        warpTo = Console.ReadLine().ToLower();
                    }
                    if (warpTo == "bedroom")
                    {
                        bedroom("sleepyMorning");
                    }
                    else
                    {
                        toilet("");
                    }
                    break;

                case "bedroom":
                    string warpTo1 = "";
                    while (warpTo1 != "kitchen" && warpTo1 != "toilet")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("(kitchen/toilet)");
                        Console.ForegroundColor = ConsoleColor.White;
                        warpTo1 = Console.ReadLine().ToLower();
                    }
                    if (warpTo1 == "kitchen")
                    {
                        kitchen("");
                    }
                    else
                    {
                        toilet("");
                    }
                    break;

                case "bathroom":
                    string warpTo2 = "";
                    while (warpTo2 != "bedroom" && warpTo2 != "kitchen")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("(bedroom/kitchen)");
                        Console.ForegroundColor = ConsoleColor.White;
                        warpTo2 = Console.ReadLine().ToLower();
                    }
                    if (warpTo2 == "bedroom")
                    {
                        bedroom("sleepyMorning");
                    }
                    else
                    {
                        kitchen("");
                    }
                    break;
            }
        }
    }
}