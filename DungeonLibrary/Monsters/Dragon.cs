using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Dragon : Monster
    {
        public bool Enraged { get; set; }

        public Dragon(string name, int life, int maxLife, int hitChance, int armor, int minDamage,
            int maxDamage, string description, bool enraged)
            : base(name, life, maxLife, hitChance, armor, maxDamage, minDamage, description)
        {
            Enraged = Enraged;
        }

        public Dragon()
        {
            Name = "Black Dragon";
            MaxLife = 400;
            Life = 375;
            HitChance = 65;
            Armor = 60;
            MinDamage = 10;
            MaxDamage = 25;
            Description = "A brilliant black dragon, gaurding it's children with all it's strength. ";
            Enraged = false;
        }
        public override int CalcDamage()
        
        {
            int calculatedDamage = MaxDamage;

            if (Enraged)
            {
                calculatedDamage += calculatedDamage / 2;
            }

            return calculatedDamage;
        }
    }
}
