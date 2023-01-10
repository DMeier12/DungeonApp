using DungeonLibrary;

    

namespace Dungeon
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Title / Introduction

            Console.Title = "Journey through Brevard";

            Console.WriteLine("Welcome to the ground continent of Brevard. \n A continent in the middle of a civil war, you're sent out to help clear some problem children.");
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

                DarkCultist cultist = new DarkCultist("Vardor", 40, 40, 95, 50, 7, 15, 
                    "A tall darkrobed figure who's chanting the worlds of a forgotten language.", true);


                Bandit bandit = new Bandit("Solarin the Bandit Lord", 30,25, 70, 40,3, 9, "He's stolen all of the Elven Silver!");

                Slime slime = new Slime("Rimuru", 17, 25, 50, 10, 1, 4,
                    "You never know what'll happen when you face something that can eat everything.", 3, 10);

                Dragon dragon = new Dragon("Blackfang", 300, 275, 45, 20, 15, 25, "The last great dragon.", true);


                #endregion

                #region Monster Selection

                Monster[] monsters = { cultist, slime, bandit, dragon };

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
                "You step into a valley, set down by a tree stump to rest for a moment, when suddenly you hear a roar...",
                "You enter a strange smelling cavern... smells like.. lavender?",
                "You arrive into a horde of gold and monsters!",
                "You enter a dingy homestead, with creaking wood floors, mold and water damage, and a figure stands in the middle.",
                "As you arrive through the hole in the wall, you fall straight onto a hard, rock floor",
                "You see an empty room with nothing but a chest by the back wall, free loot! Oh no... you're glued to a mimic!",
                "As you walk into the room, you hear DOOM 2016 music blaring.",
                "As you're looking upon the beautiful Brevard water falls, you feel a sticky wet substance hit your shoulder.",
            };
            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);
            string room = rooms[indexNbr];
            return room;
        }

        #endregion

    }//end class

}//end Namespace
