using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    internal class Dagger : Weapon
    {
        int MaxDamage = 6;
        int MinDamage = 2;
        string Name = "Basic Dagger";
        int BonusHitChance = 25;
        bool IsTwoHanded = false;
        WeaponType Type = WeaponType.Dagger;
        public Dagger(int minDamage, int maxDamage, string name, int bonusHitChance,
            bool isTwohanded, WeaponType type) : base(minDamage, maxDamage, name, bonusHitChance, isTwohanded, type) { }
    }
}
