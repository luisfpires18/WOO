namespace WOO.Data.Model
{
    public class Class
    {
        public Guid ClassId { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }

        public int BaseHealth { get; set; }

        public int BaseAttackPower { get; set; }
        public int BaseMagicPower { get; set; }

        public int BaseArmor { get; set; }
        public int BaseResistance { get; set; }

        // Nav;
        public IEnumerable<Player> Players { get; set; }

        public IEnumerable<WeaponType> Weapons { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
    }
}