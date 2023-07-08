namespace WOO.Data.Repository.Model
{
    public class Reward
    {
        public Guid RewardId { get; set; }

        public int Experience { get; set; }
        public int Gold { get; set; }

        public Guid QuestId { get; set; }

        public Quest Quest { get; set; }
        public IEnumerable<ItemReward> ItemRewards { get; set; }
    }
}