using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    internal class ChainMail : ArmorClass
    {
        
            int ArmorValue = 30;
            string Name = "Chain Mail";
        public ChainMail(int ArmorValue, string Name) : base(ArmorValue, Name) { }
       
    }
}
