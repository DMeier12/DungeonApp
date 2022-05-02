using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{

     public class Player : Character
    {


        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public ArmorClass EquippedArmor { get; set;  }
        public Iclass CharacterClass { get; set; }
        public int Intellect
        {
            get { return CharacterClass.Intellect; }
        }
        public int Dexterity
        {
            get { return CharacterClass.Dexterity; }
            set { Armor = Armor + 2; }
        }
        private int _armor = 0;
        public int Armor { 
            get {
                var calcArmor = ((Dexterity - 5) * 2);
                return _armor += _armor + calcArmor;} 
            private set { _armor = value; } }
        public int Strength
        {
            get { return CharacterClass.Strength; }
        }
        public int Vitality
        {
            get { return CharacterClass.Vitality; }
        }
        public Player(string name, int hitChance, int armor, int maxLife, int life, Race characterRace,
            Weapon equippedWeapon, ArmorClass equippedArmor) : base(name, hitChance, armor, maxLife, life)
        {

            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            EquippedArmor = equippedArmor;

            #region Potential Expansion - Racial Bonuses

            //switch (CharacterRace)
            //{
            //    case Race.Elf:
            //        HitChance += 5;
            //        break;
            //}

            #endregion
        }

        public override string ToString()
        {

            string description = "";

            switch (CharacterRace)
            {
                case Race.Orc:

                    description = "Orc";
                    break;
                case Race.Human:
                    description = "Human";
                    break;
                case Race.Elf:
                    description = "Elf";
                    break;
                case Race.Volarian:
                    description = "Volarian";
                    break;
                case Race.Zaliar:
                    description = "Zaliar";
                    break;
                case Race.Aasimar:
                    description = "Aasimar";
                    break;
                case Race.Boriax:
                    description = "Boriax";
                    break;
                case Race.Yordle:
                    description = "Yordle";
                    break;

            }

            return string.Format("-=-= {0} =-=-\n" +
                "Life: {1} of {2}\nHit Chance: {3}%\n" +
                "Weapon:\n{4}\nArmor: {5}\nDescription: {6}",
                Name,
                Life,
                MaxLife,
                HitChance,
                EquippedWeapon,
                Armor,
                description);
        }

        public override int CalcDamage()
        {

            Random rand = new Random();

            int damage = rand.Next(EquippedWeapon.MinDamage,
                EquippedWeapon.MaxDamage + 1);

            return damage;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }
    }
}
