using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class ArmorClass
    {
        private int _armorValue;
        private string _name;
        public int ArmorValue
        {
            get { return _armorValue; }
            set { _armorValue = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public ArmorClass(int ArmorValue, string Name)
        {
            _armorValue = ArmorValue;
            _name = Name;
        }

    }
}
