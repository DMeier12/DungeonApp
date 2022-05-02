using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Spells
{
    internal class Frostbolt2 : SpellCasting
    {
        int spellMaxDamage = 60;
        int spellMinDamage = 40;
        int spellLevel = 2;
        string spellName = "FrostBolt";
        string spellDescription = "A small blast of fire in the shape of a ball";
        public Frostbolt2(int spellMaxDamage, int spellMinDamage, int spellLevel, string spellName, string spellDescription) : base(spellMaxDamage, spellMinDamage, spellLevel, spellName, spellDescription) { }
    }
}
