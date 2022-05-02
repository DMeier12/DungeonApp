using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Armor
{
    internal class Padded : ChainMail
    {
        int ArmorValue = 35;
        string Name = "Armor made of padded quilts";
        public Padded(int ArmorValue, string Name) : base(ArmorValue, Name) { }
    }
}
