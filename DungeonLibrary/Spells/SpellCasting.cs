using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class SpellCasting
    {
        private int _spellMaxDamage;
        private int _spellMinDamage;
        private int _spellLevel;
        private string _spellName;
        private string _spellDescription;

        public int SpellMaxDamage
        {
            get { return _spellMaxDamage; }                
            set { _spellMaxDamage = value; }
        }
        public int SpellMinDamage
        {
            get { return _spellMinDamage; }
            set
            {
                if (value > 0 && value <= _spellMaxDamage)
                {
                    _spellMinDamage = value;
                }
                else
                {
                    _spellMinDamage = 1;
                }

            }
        }
        public int SpellLevel
        {
            get { return _spellLevel; }
            set { _spellLevel = value; }
        }
        public string SpellName
        {
            get { return _spellName; }
            set { _spellName = value; }
        }
        public string SpellDescription
        {
            get { return _spellDescription; }
            set { _spellDescription = value; }
        }

        public SpellCasting(int spellMaxDamage, int spellMinDamage, int spellLevel, string spellName, string spellDescription)
        {
            _spellMaxDamage = spellMaxDamage;
            _spellMinDamage = spellMinDamage;
            _spellLevel = spellLevel;
            _spellName = spellName;
            _spellDescription = spellDescription;
        }
 
    }
}
