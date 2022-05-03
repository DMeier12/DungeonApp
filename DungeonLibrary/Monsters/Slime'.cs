using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Slime : Monster
    {
        public int BonusArmor { get; set; }
        public int HidePercent { get; set; }

        public Slime(string name, int life, int maxLife, int hitChance, int block, int minDamage,
            int maxDamage, string description, int bonusArmor, int hidePercent) 
            : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            BonusArmor = bonusArmor;
            HidePercent = hidePercent;
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}% chance it will harden, granting {2} bonus armor.",
                base.ToString(), HidePercent, BonusArmor);
        }

        public override int CalcArmor()
        {
            int calculatedArmor = Armor;

            Random rand = new Random();
            int percent = rand.Next(101);

            if (percent <= HidePercent)
            {

                calculatedArmor += BonusArmor;
            }
            return calculatedArmor;
        }
    }
}
