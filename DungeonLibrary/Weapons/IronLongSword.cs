using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Weapons
{
    internal class IronLongSword : Weapon
    {
        int MaxDamage = 12;
        int MinDamage = 3;
        string Name = "Iron Long Sword";
        int BonusHitChance = 25;
        bool IsTwoHanded = false;
        WeaponType Type = WeaponType.Iron_Long_Sword;
        public IronLongSword(int minDamage, int maxDamage, string name, int bonusHitChance,
            bool isTwohanded, WeaponType type) : base(minDamage, maxDamage, name, bonusHitChance, isTwohanded, type) { }
    }
}
