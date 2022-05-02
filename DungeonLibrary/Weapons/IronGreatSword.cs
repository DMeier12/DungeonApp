using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Weapons
{
    internal class IronGreatSword : Weapon
    {
        int MaxDamage = 13;
        int MinDamage = 5;
        string Name = "Iron Great Sword";
        int BonusHitChance = 15;
        bool IsTwoHanded = true;
        WeaponType Type = WeaponType.Iron_Long_Sword;
        public IronLongSword(int minDamage, int maxDamage, string name, int bonusHitChance,
            bool isTwohanded, WeaponType type) : base(minDamage, maxDamage, name, bonusHitChance, isTwohanded, type) { }
    }
}
