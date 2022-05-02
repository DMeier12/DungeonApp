using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Weapons
{
    internal class BoStaff : Weapon
    {
        int MaxDamage = 14;
        int MinDamage = 6;
        string Name = "a long bo staff";
        int BonusHitChance = 15;
        bool IsTwoHanded = true;
        WeaponType Type = WeaponType.Long_Sword;
        public BoStaff(int minDamage, int maxDamage, string name, int bonusHitChance,
            bool isTwohanded, WeaponType type) : base(minDamage, maxDamage, name, bonusHitChance, isTwohanded, type) { }
    }
}
