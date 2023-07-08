namespace WOO.Data.Repository.Model
{
    public class Stats
    {
        public int Level { get; set; }
        public double Experience { get; set; }
        public double ExperienceNeeded { get; set; }
        public float TotalGold { get; set; }

        public double Health { get; set; }
        public int Resource { get; set; }

        public double AttackPower { get; set; }
        public double MagicPower { get; set; }

        public double Armor { get; set; }
        public double Resistance { get; set; }
    }
}