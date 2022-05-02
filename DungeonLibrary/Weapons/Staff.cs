using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Weapons
{
    internal class Staff
    {
        int MaxDamage = 10;
        int MinDamage = 4;
        string Name = "Wood Staff";
        int BonusHitChance = 10;
        bool IsTwoHanded = true;
        WeaponType Type = WeaponType.Staff;
        public Staff(int minDamage, int maxDamage, string name, int bonusHitChance,
            bool isTwohanded, WeaponType type) : base(minDamage, maxDamage, name, bonusHitChance, isTwohanded, type) { }
    }
}
