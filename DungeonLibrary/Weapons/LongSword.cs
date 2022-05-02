using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DungeonLibrary
{
    public class LongSword : Weapon
    {
        int MaxDamage = 8;
        int MinDamage = 1;
        string Name = "Long Sword";
        int BonusHitChance = 15;
        bool IsTwoHanded = false;
        WeaponType Type = WeaponType.Long_Sword;
        public LongSword(int minDamage, int maxDamage, string name, int bonusHitChance,
            bool isTwohanded, WeaponType type) : base(minDamage, maxDamage, name, bonusHitChance, isTwohanded, type) { }
    }
}