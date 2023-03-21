namespace WOO.Data.Model
{
    public class ItemReward
    {
        public int ItemQuantity { get; set; }
        public Guid ItemId { get; set; }
        public Guid RewardId { get; set; }

        public Item Item { get; set; }
        public Reward Reward { get; set; }
    }
}