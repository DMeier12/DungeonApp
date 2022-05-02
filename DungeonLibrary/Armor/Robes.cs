using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Armor
{
    internal class Robes : ChainMail
    {
        int ArmorValue = 10;
        string Name = "Robes";
        public Robes(int ArmorValue, string Name) : base(ArmorValue, Name) { }
    }
}
