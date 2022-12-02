using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Fiction
{
    internal class Program
    {
        static string[] story = {
                "You live in the middle of a forest with your wife and two children. You built a house that keeps your family warm in Winter, a well that supplied you with clean water and a hunting tower to bring fresh meat. You're cooking the deer you hunted today when you see glowing eyes peering in the moonlight.;Take a few steps closer...;Run into the house and lock the front door.;2;3",
                "You tiptoe. The eyes vanish and you see a glimpse of the body.;Chase the figure.;Pretend like you never saw anything.;5;4",
                "You dash left into the kitchen and look out the window. You see it now, it's a wolf.;You reassure your family that everything is alright and you all go to bed feeling safe from the dangers of the outside world.",
                "You're almost back home. You're a bit angry and trip over a twig. Your clothes are dirty. It has been a long day but you're happy now that you're with your family.",
                "You take your lantern. The figure runs into a cave, you're starting to realize this is dangerous.;Go into the cave.;Head back;9;7",
                "The next morning comes, the birds are singing, the sun is shining, your children are calling your name. They found you! You're crying with joy.;You come back home to a warm vegetable stew. You play ball with your children and you dance with your wife. It has been a wonderful day.",
                "You forgot where your home is. You start to worry.;Climb a tree to sleep in.;Continue searching.;6;8",
                "You're becoming restless and hungry. You hear howling. That's not good. You see the same eyes staring at you. Multiple.",
                "The cave is dark. The eyes stop and turn toward you. You extend your arm for a better view. It's a wolf.;Freeze, then stare at the wolf.;Run away.;11;10",
                "The wolf chases you. Luckily, there is a big rock that will give you high ground. You climb it and the wolf runs away. You make your way back home.",
                "Without showing fear, the wolf runs away into the cave. You get back home and you're greeted with dinner. Your family is relieved that you're back and you finally get some sleep."
            };
        static string[] endings = {"",
                "",
                "You've unlocked the safe ending.",
                "",
                "You've unlocked the rough ending.",
                "You've unlocked the happy ending.",
                "",
                "You've unlocked the sad ending.",
                "",
                "You've unlocked the tiresome ending.",
                "You've unlocked the curious ending."
            };
        static int currentPage = 1;
        static string nextPage;
        static string[] page1 = story[0].Split(';');
        static string[] page2 = story[1].Split(';');
        static string[] page3 = story[2].Split(';');
        static string[] page4 = story[3].Split(';');
        static string[] page5 = story[4].Split(';');
        static string[] page6 = story[5].Split(';');
        static string[] page7 = story[6].Split(';');
        static string[] page8 = story[7].Split(';');
        static string[] page9 = story[8].Split(';');
        static string[] page10 = story[9].Split(';');
        static string[] page11 = story[10].Split(';');
        static bool gameEnded = false;
        static void Main(string[] args)
        {
            start_game();
            game_loop(page1);
            while (!gameEnded)
            {
                choose_page();
            }            
            Console.ReadKey();
        }

        static void start_game()
        {
            Console.WriteLine("ADJUST CONSOLE SCREEN SIZE");
            Console.WriteLine(". . .then press any key to begin. . .");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("There are 6 possible endings.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Interactive Fiction - First Playable project");
            Console.WriteLine("____________________________________________");
            Console.WriteLine();
            Console.WriteLine("- Campus: NSCC Truro Campus");
            Console.WriteLine("- Program: Game Development (Common / No Concentration)");
            Console.WriteLine("- Course: Logic and Programming I");
            Console.WriteLine("- Date: November, 2022");
            Console.WriteLine("- Name: Balázs Kiss");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The Dangers of the Forest");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("_________");
            Console.WriteLine("A - New Game");
            Console.WriteLine();
            Console.Write("> ");
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.A)
                {
                    Console.Clear();
                    Console.WriteLine("New Game!");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PAGE 1:");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }
        }

        static void game_loop(string[] page)
        {
            if (page.Length == 5)
            {
                Console.WriteLine(page[0]);
                Console.WriteLine();
                Console.WriteLine("MAKE YOUR CHOICE:");
                Console.WriteLine();
                Console.Write("A - " + page[1] + "");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("...goes to page " + page[3]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("B - " + page[2] + "");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("...goes to page " + page[4]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                while (true)
                {
                    string choice = Console.ReadLine();
                    if (choice == "A")
                    {
                        nextPage = page[3];
                        break;
                    }
                    else if (choice == "B")
                    {
                        nextPage = page[4];
                        break;
                    }
                }
                Console.WriteLine();
            }
            else
            {
                for (int x = 0; x < page.Length; x++)
                {
                    Console.WriteLine(page[x]);
                    Console.WriteLine();
                }
                Console.WriteLine(endings[currentPage]);
                gameEnded = true;
            }
        }

        static void choose_page()
        {
            switch (nextPage)
            {
                case "1":
                    game_loop(page1);
                    break;
                case "2":
                    game_loop(page2);
                    break;
                case "3":
                    game_loop(page3);
                    break;
                case "4":
                    game_loop(page4);
                    break;
                case "5":
                    game_loop(page5);
                    break;
                case "6":
                    game_loop(page6);
                    break;
                case "7":
                    game_loop(page7);
                    break;
                case "8":
                    game_loop(page8);
                    break;
                case "9":
                    game_loop(page9);
                    break;
                case "10":
                    game_loop(page10);
                    break;
                case "11":
                    game_loop(page11);
                    break;
            }
        }
    }
}
