using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Armor
{
    internal class HalfPlate : ChainMail
    {
        int ArmorValue = 25;
        string Name = "Half Plate";
        public HalfPlate(int ArmorValue, string Name) : base(ArmorValue, Name) { }
    }
}
