using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Spells
{
    internal class ArcaneBlast2 : SpellCasting
    {
        int spellMaxDamage = 65;
        int spellMinDamage = 35;
        int spellLevel = 2;
        string spellName = "Arcane Blast";
        string spellDescription = "A small blast of Aracane Energy";
        public ArcaneBlast2(int spellMaxDamage, int spellMinDamage, int spellLevel, string spellName, string spellDescription) : base(spellMaxDamage, spellMinDamage, spellLevel, spellName, spellDescription) { }
    }
}
