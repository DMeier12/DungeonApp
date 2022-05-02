using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Weapons
{
    internal class Mace : Weapon
    {
        int MaxDamage = 8;
        int MinDamage = 3;
        string Name = "Mace";
        int BonusHitChance = 20;
        bool IsTwoHanded = false;
        WeaponType Type = WeaponType.Mace;
        public Mace(int minDamage, int maxDamage, string name, int bonusHitChance,
            bool isTwohanded, WeaponType type) : base(minDamage, maxDamage, name, bonusHitChance, isTwohanded, type) { }
    }
}
