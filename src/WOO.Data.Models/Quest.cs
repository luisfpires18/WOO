namespace WOO.Data.Model
{
    public class Quest
    {
        public int QuestId { get; set; }

        public string Name { get; set; }

        public string Place { get; set; }

        public int LevelRequired { get; set; }

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public DateTime? DateToComplete { get; set; }

        public bool Status { get; set; }

        public IEnumerable<Reward> Rewards { get; set; }
    }
}