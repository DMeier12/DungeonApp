using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Weapons
{
    internal class Great_Axe : Weapon
    {
        int MaxDamage = 12;
        int MinDamage = 6;
        string Name = "Great Axe";
        int BonusHitChance = 15;
        bool IsTwoHanded = true;
        WeaponType Type = WeaponType.Great_Axe;
        public Great_Axe(int minDamage, int maxDamage, string name, int bonusHitChance,
            bool isTwohanded, WeaponType type) : base(minDamage, maxDamage, name, bonusHitChance, isTwohanded, type) { }
    }
}
