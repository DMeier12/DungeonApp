using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Spells
{
    internal class Frostbolt : SpellCasting
    {
        int spellMaxDamage = 40;
        int spellMinDamage = 20;
        int spellLevel = 1;
        string spellName = "Frostbolt";
        string spellDescription = "A small blast of frost in the shape of a ball";
        public Frostbolt(int spellMaxDamage, int spellMinDamage, int spellLevel, string spellName, string spellDescription) : base(spellMaxDamage, spellMinDamage, spellLevel, spellName, spellDescription) { }
    }
}
