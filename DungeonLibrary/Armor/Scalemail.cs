﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary.Armor
{
    internal class Scalemail : ChainMail
    {
        int ArmorValue = 35;
        string Name = "Scale Mail";
        public Scalemail(int ArmorValue, string Name) : base(ArmorValue, Name) { }
    }
}
