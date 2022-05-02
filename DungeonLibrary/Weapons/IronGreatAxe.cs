using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Weapons
{
    internal class IronGreatAxe : Weapon
    {
        int MaxDamage = 16;
        int MinDamage = 8;
        string Name = "Iron Great Axe";
        int BonusHitChance = 15;
        bool IsTwoHanded = true;
        WeaponType Type = WeaponType.Iron_Great_Axe;
        public IronGreatAxe(int minDamage, int maxDamage, string name, int bonusHitChance,
            bool isTwohanded, WeaponType type) : base(minDamage, maxDamage, name, bonusHitChance, isTwohanded, type) { }
    }
}
