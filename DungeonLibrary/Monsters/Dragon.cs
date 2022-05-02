using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Dragon : Monster
    {
        public bool IsScaly { get; set; }

        public Dragon(string name, int life, int maxLife, int hitChance, int block, int minDamage,
            int maxDamage, string description, bool isScaly)
            : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            IsScaly = isScaly;
        }

        public Dragon()
        {
            Name = "Baby Dragon";
            MaxLife = 10;
            Life = 10;
            HitChance = 40;
            Armor = 10;
            MinDamage = 1;
            MaxDamage = 5;
            Description = "Though just a hatchling, this dragon is still dangerous.";
            IsScaly = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsScaly ? "Coated in thick scales" : "Has a soft, underdeveloped hide");
        }

        public override int CalcArmor()
        {
            int calculatedArmor = Armor;

            if (IsScaly)
            {
                calculatedArmor += calculatedArmor / 2;
            }

            return calculatedArmor;
        }
    }
}
