using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //Make this class public and inherit from Character
    public class Monster : Character
    {
        //We need custom business rules for min damage, 
        //so we need to declare the field here.
        private int _minDamage;

        //Auto-properties
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        //MinDamage property with custom business rules
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //MinDamage can't exceed MaxDamage & can't be less than 1
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }
        public Monster() { }
        //Fully qualified constructor that inherits assignment from Character
        public Monster(string name, int life, int maxLife, int hitChance, int block, int maxDamage,
            int minDamage, string description) : base(name, hitChance, block, maxLife, life)
        {
            //Assign the remaining unique properties for Monster
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            if (description != null) { Description = description; }
            else
            {
                Description = "";
            }
        }

        

        //override the ToString()
        public override string ToString()
        {
            return string.Format("\n********** MONSTER **********\n" +
                "{0}\nLife: {1} of {2}\nDamage: {3} to {4}\n" +
                "Block: {5}\nDescription:\n{6}\n",
                Name, Life, MaxLife, MinDamage, MaxDamage, Block, Description);
        }

        //override Character's CalcDamage() to use the Monster's min & max damage
        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }
    }
}
