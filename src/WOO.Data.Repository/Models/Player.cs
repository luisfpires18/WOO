namespace WOO.Data.Repository.Model
{
    public class Player : BaseEntity
    {
        public int PlayerId { get; set; }

        public string Username { get; set; } = string.Empty;
    }
}