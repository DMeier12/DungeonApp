using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
       
        public static void doAttack(Character attacker, Character defender)
        {
            Random rand = new Random();
            int roll = rand.Next(1, 101);


            Thread.Sleep(30);

            if (roll <= (attacker.CalcHitChance() - defender.CalcArmor()))
            {
                int damageDealt = attacker.CalcDamage();
                //defender.Life -= damageDealt;
                defender.ApplyDamage(damageDealt);
                
                Console.ForegroundColor = ConsoleColor.Red;
                
                Console.WriteLine("{0} hit {1} for {2} damage!",
                    attacker.Name, defender.Name, damageDealt);
                
                Console.ResetColor();

            }
            else
            {
                Console.WriteLine("{0} missed!", attacker.Name);
            }
        }
        public static void DoBattle(Player player, Monster monster)
        {

            doAttack(player, monster);

            if (monster.Life > 0)
            {
                doAttack(monster, player);
            }
        }
    }
}
