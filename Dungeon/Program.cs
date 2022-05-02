using DungeonLibrary;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Title / Introduction

            Console.Title = "Journey through Brevard";

            Console.WriteLine("Your journey begins...");

            #endregion

            int score = 0;

            Weapon longSword = new Weapon(1, 8, "Long Sword", 10, false, WeaponType.Long_Sword);
            ArmorClass chainMail = new ArmorClass(30, "Chainmail");
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome, {0}!", userName);
            Console.WriteLine("Choose your race: \n" + GetRaces());
            var playerRaceChoice = Console.ReadLine();
            Race playerRace = new Race();
            switch (playerRaceChoice?.ToUpper())
            {
                case "H":
                    playerRace = Race.Human;

                    break;
                case "E":
                    playerRace = Race.Elf;

                    break;
                case "O":
                    playerRace = Race.Orc;

                    break;
                case "V":
                    playerRace = Race.Volarian;

                    break;
                case "Z":
                    playerRace = Race.Zaliar;
                    break;
                case "A":
                    playerRace = Race.Aasimar;

                    break;
                case "B":
                    playerRace = Race.Boriax;

                    break;
                case "Y":
                    playerRace = Race.Yordle;

                    break;

                default:

                    break;
            }

            Player player = new(userName, 95, 10, 100, 100, playerRace, longSword, chainMail);
            Console.WriteLine("Choose your class: \n" + GetClass());

            switch (Console.ReadLine().ToUpper())
            {
                case "W":
                    player.CharacterClass = new Warrior();
                    
                    break;
                case "M":
                    player.CharacterClass = new Mage();

                    break;
                case "R":
                    player.CharacterClass = new Rogue();

                    break;
                case "A":
                    player.CharacterClass = new Archer();

                    break;
                case "P":
                    player.CharacterClass = new Priest();
                    
                    
                    break;
                default:
                    break;
            }
            #region Main Game Loop

            bool exit = false;

            do
            {
                Console.WriteLine(GetRoom());


                #region Monster Objects

                Rabbit rabbit = new Rabbit("White Rabbit", 25, 25, 50, 20, 2, 8,
                    "That's no ordinary rabbit! Look at the bones!", true);

                Rabbit babyRabbit = new Rabbit();

                Vampire vampire = new Vampire("Dracula", 25, 30, 70, 8, 1, 8, "The father of all undead.");

                Turtle turtle = new Turtle("Mikey", 17, 25, 50, 10, 1, 4,
                    "He's no longer a teenager, but he's still a mutant turtle.", 3, 10);

                Dragon dragon = new Dragon("Smaug", 10, 20, 65, 20, 1, 15, "The last great dragon.", true);

                Dragon babyDragon = new Dragon();

                #endregion

                #region Monster Selection

                Monster[] monsters = { rabbit, turtle, vampire, dragon };

                Random rand = new Random();
                int randomNbr = rand.Next(monsters.Length);
                Monster monster = monsters[randomNbr];

                Console.WriteLine("\nIn this room you encounter: " + monster.Name);

                #endregion

                #region Gameplay Menu Loop

                bool reload = false;

                do
                {

                    #region Gameplay Menu

                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run away\n" +
                        "P) Player info\n" +
                        "M) Monster info\n" +
                        "X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;

                    Console.Clear();

                    switch (userChoice)
                    {

                        case ConsoleKey.A:
                            Console.WriteLine("Attack");

                            Combat.DoBattle(player, monster);

                            if (monster.Life <= 0)
                            {

                                Console.ForegroundColor = ConsoleColor.Green;

                                Console.WriteLine("\n You killed {0}!\n", monster.Name);
                                Console.ResetColor();

                                score++;

                                reload = true;
                            }
                            break;

                        case ConsoleKey.R:
                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.doAttack(monster, player);

                            Console.WriteLine();

                            reload = true;


                            break;

                        case ConsoleKey.P:

                            Console.WriteLine(player);
                            Console.WriteLine("Monsters defeated: " + score);
                            break;

                        case ConsoleKey.M:
                            Console.WriteLine("Monster info");

                            Console.WriteLine(monster);
                            break;

                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("The weak always quit before things get rough.");

                            exit = true;
                            break;

                        default:

                            Console.WriteLine("You've chosen an incorrect option, please try again.");

                            break;
                    }

                    #endregion

                    if (player.Life <= 0)
                    {
                        Console.WriteLine("You have been defeated!");

                        exit = true;

                    }

                } while (!exit && !reload);

                #endregion


            } while (!exit);

            #endregion


            Console.WriteLine("You defeated " + score + "monster" +
                ((score == 1) ? "." : "s."));


        }

        private static string GetRaces()
        {
            string races = "";
            foreach (var race in Race.GetValues(typeof(Race)))
            {
               races += race.ToString().Substring(0, 1).ToUpper() + ") " + race.ToString() + "\n";
            }
            return races;
        }
        private static string GetClass()
        {
            string classes = "";
            foreach (var _class in playerClass.GetValues(typeof(playerClass)))
            {
            classes += _class.ToString().Substring(0, 1).ToUpper() + ") " + _class.ToString() + "\n";
            }
            return classes;
        }
        #region GetRoom()

        private static string GetRoom()
        {
            string[] rooms =
            {
                "The room is dark and musty with the smell of lost souls.",
                "You enter a pretty pink powder room and instantly get glitter on you.",
                "You arrive in a room filled with chairs and a ticket stub machine... the dreaded DMV",
                "You enter a quiet library... silence... nothing but silence....",
                "As you enter the room, you realize you are standing on a platform surrounded by sharks",
                "Oh my.... what is that smell? You appear to be standing in a compost pile",
                "You enter a dark room and all you can hear is hair metal music blaring.... This is going to be bad!",
                "The room looks just like the room you are sitting in right now... or does it?",
            };
            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);
            string room = rooms[indexNbr];
            return room;
        }

        #endregion

    }//end class

}//end Namespace
