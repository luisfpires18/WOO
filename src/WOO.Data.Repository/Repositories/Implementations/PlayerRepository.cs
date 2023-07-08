namespace WOO.Data.Repository.Implementations
{
    using WOO.Data.Repository.Contexts;
    using WOO.Data.Repository.Interfaces;
    using WOO.Data.Repository.Model;

    public class PlayerRepository : IPlayerRepository
    {
        private readonly WooDBContext wooDBContext;

        public PlayerRepository(WooDBContext wooDBContext)
        {
            this.wooDBContext = wooDBContext;
        }

        public Player? GetPlayerById(int id)
        {
            if (this.wooDBContext.Players == null)
            {
                return null;
            }

            return this.wooDBContext.Players.First(e => e.PlayerId == id);
        }

        public IEnumerable<Player> GetAll()
        {
            return this.wooDBContext.Players;
        }

        public IEnumerable<Player> SearchPlayers(string searchQuery)
        {
            return this.wooDBContext.Players.Where(p => p.Username.Contains(searchQuery));
        }
    }
}