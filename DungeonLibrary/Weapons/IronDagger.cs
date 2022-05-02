using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Weapons
{
    internal class IronDagger : Weapon
    {
        int MaxDamage = 8;
        int MinDamage = 3;
        string Name = "Iron Dagger";
        int BonusHitChance = 20;
        bool IsTwoHanded = false;
        WeaponType Type = WeaponType.Iron_Dagger;
        public IronDagger(int minDamage, int maxDamage, string name, int bonusHitChance,
            bool isTwohanded, WeaponType type) : base(minDamage, maxDamage, name, bonusHitChance, isTwohanded, type) { }
    }
}
