using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Spells
{
    internal class Fireball2 : SpellCasting
    {
        int spellMaxDamage = 60;
        int spellMinDamage = 50;
        int spellLevel = 2;
        string spellName = "Fireball level 2";
        string spellDescription = "A medium-sized blast of fire in the shape of a ball";
        public Fireball2(int spellMaxDamage, int spellMinDamage, int spellLevel, string spellName, string spellDescription) : base(spellMaxDamage, spellMinDamage,spellLevel, spellName, spellDescription) { }
    }
}
