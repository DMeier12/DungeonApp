using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Weapons
{
    internal class Bow : Weapon
    {
        int MaxDamage = 10;
        int MinDamage = 4;
        string Name = "Bow";
        int BonusHitChance = 30;
        bool IsTwoHanded = true;
        WeaponType Type = WeaponType.Bow;
        public Bow(int minDamage, int maxDamage, string name, int bonusHitChance,
            bool isTwohanded, WeaponType type) : base(minDamage, maxDamage, name, bonusHitChance, isTwohanded, type) { }
    }
}
