using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Armor
{
    internal class Leather : ChainMail
    {
        int ArmorValue = 20;
        string Name = "Leather armor";
        public Leather(int ArmorValue, string Name) : base(ArmorValue, Name) { }
    }
}
