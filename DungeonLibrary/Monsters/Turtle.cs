using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Turtle : Monster
    {
        public int BonusBlock { get; set; }
        public int HidePercent { get; set; }

        public Turtle(string name, int life, int maxLife, int hitChance, int block, int minDamage,
            int maxDamage, string description, int bonusBlock, int hidePercent) 
            : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            BonusBlock = bonusBlock;
            HidePercent = hidePercent;
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}% chance it will hide, granting {2} bonus block.",
                base.ToString(), HidePercent, BonusBlock);
        }

        public override int CalcArmor()
        {
            int calculatedBlock = Armor;

            //Generate a random number from 0-100
            Random rand = new Random();
            int percent = rand.Next(101);

            //Check if that's less than or equal to the hide percent
            if (percent <= HidePercent)
            {
                //If it is, add the bonus block
                calculatedBlock += BonusBlock;
            }

            //Return the total
            return calculatedBlock;
        }
    }
}
