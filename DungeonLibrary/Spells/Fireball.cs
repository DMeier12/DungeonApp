using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Spells
{
    internal class Fireball : SpellCasting
    {
        int spellMaxDamage = 40;
        int spellMinDamage = 30;
        int spellLevel = 1;
        string spellName = "Fireball";
        string spellDescription = "A small blast of fire in the shape of a ball";
        public Fireball(int spellMaxDamage, int spellMinDamage, int spellLevel, string spellName, string spellDescription) : base(spellMaxDamage,spellMinDamage,spellLevel,spellName,spellDescription) { }
    }
}
