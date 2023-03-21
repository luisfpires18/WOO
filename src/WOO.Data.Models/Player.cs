namespace WOO.Data.Model
{
    public class Player : BaseEntity
    {
        public int PlayerId { get; set; }

        public string Username { get; set; } = string.Empty;
    }
}