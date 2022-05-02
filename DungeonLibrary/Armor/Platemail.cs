using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Armor
{
    internal class Platemail : ChainMail
    {
        int ArmorValue = 40;
        string Name = "Plate Mail";
        public Platemail(int ArmorValue, string Name) : base(ArmorValue, Name) { }
    }
}
