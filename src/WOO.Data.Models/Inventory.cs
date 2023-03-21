namespace WOO.Data.Model
{
    public class Inventory
    {
        public Guid PlayerId { get; set; }
        public Guid ItemId { get; set; }
        public int Quantity { get; set; }

        public Player Player { get; set; }

        public Item Item { get; set; }
    }
}