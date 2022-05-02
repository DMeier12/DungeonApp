using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Weapon_Types
{
    internal class GreatSword : Weapon
    {
        int MaxDamage = 10;
        int MinDamage = 3;
        string Name = "Great Sword";
        int BonusHitChance = 10;
        bool IsTwoHanded = true;
        WeaponType Type = WeaponType.Great_Sword;
        public GreatSword(int minDamage, int maxDamage, string name, int bonusHitChance,
            bool isTwohanded, WeaponType type) : base(minDamage, maxDamage, name, bonusHitChance, isTwohanded, type) { }
    }
}
