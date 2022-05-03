using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class DarkCultist : Monster
    {
        public bool IsEmpowered { get; set; }

        public DarkCultist(string name, int life, int maxLife, int hitChance, int armor, int minDamage,
            int maxDamage, string description, bool isEmpowered)
            : base(name, life, maxLife, hitChance, armor, maxDamage, minDamage, description)
        {
            IsEmpowered = IsEmpowered;
        }

        public DarkCultist()
        {
            Name = "Cultist of Baelir";
            MaxLife = 40;
            Life = 40;
            HitChance = 95;
            Armor = 10;
            MinDamage = 10;
            MaxDamage = 12;
            Description = "He's in the middle of casting a ritual, clask in a dark robe, hood up, changting an unknown to you language.";
            IsEmpowered = true;
        }

        public override string ToString()
        {
            return base.ToString() + (IsEmpowered ? "Dark energy surrounds his actions and words" : "He just looks like a crazy man.");
        }

        public override int CalcDamage()
        {
            return base.CalcDamage();
        }

    }
}
