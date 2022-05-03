using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Bandit : Monster
    {
        public DateTime HourChangeBack { get; set; }

        public Bandit(string name, int life, int maxLife, int hitChance, int armor, int minDamage,
            int maxDamage, string description)
            : base(name, life, maxLife, hitChance, armor, maxDamage, minDamage, description)
        {
            


        }
    }
}
