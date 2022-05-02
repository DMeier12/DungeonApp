using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Spells
{
    internal class ArcaneBlast : SpellCasting
    {
        int spellMaxDamage = 40;
        int spellMinDamage = 20;
        int spellLevel = 1;
        string spellName = "Arcane Blast";
        string spellDescription = "A small blast of Aracane Energy";
        public ArcaneBlast(int spellMaxDamage, int spellMinDamage, int spellLevel, string spellName, string spellDescription) : base(spellMaxDamage, spellMinDamage, spellLevel, spellName, spellDescription) { }
    }
}
