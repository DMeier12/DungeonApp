using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DungeonLibrary.Weapons
{
    internal class LongBow : Weapon
    {
        int MaxDamage = 15;
        int MinDamage = 6;
        string Name = "Long Bow";
        int BonusHitChance = 15;
        bool IsTwoHanded = true;
        WeaponType Type = WeaponType.Long_Bow;
        public LongBow(int minDamage, int maxDamage, string name, int bonusHitChance,
            bool isTwohanded, WeaponType type) : base(minDamage, maxDamage, name, bonusHitChance, isTwohanded, type) { }
    }
}
