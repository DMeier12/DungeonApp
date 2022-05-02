namespace DungeonLibrary
{

    public abstract class Character
    {

        private int _life;
        private string _name;
        private int _hitChance;
        private int _armor;
        private int _maxLife;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public int Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }

        internal void ApplyDamage(int damageDealt)
        {
             Life -= Convert.ToInt16(damageDealt - (Armor * .1));

        }
        public void Heal()
        {
            Life = MaxLife;
        }

        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {

                    _life = value;
                }
                else
                {

                    _life = MaxLife;
                }
            }
        }

        


        public Character(string name, int hitChance, int armor, int maxLife, int life)
        {
            Name = name;
            HitChance = hitChance;
            Armor = armor;
            MaxLife = maxLife;
            Life = life;
            
        }
        public Character() { }
        public Character(string name, int hitChance) { }

        public override string ToString()
        {
            return string.Format("----- {0}--------\n" +
                "Life: {1} of {2}\nHit Chance: {3}%\n" +
                "Armor: {4}",
                Name,
                Life,
                MaxLife,
                HitChance,
                Armor);
        }
        public virtual int CalcArmor()
        {
            return Armor;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;
        }
    }
}