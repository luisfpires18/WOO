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
            if (wooDBContext.Players == null)
            {
                return null;
            }

            return wooDBContext.Players.First(e => e.PlayerId == id);
        }

        public IEnumerable<Player> GetAll()
        {
            return wooDBContext.Players;
        }

        public IEnumerable<Player> SearchPlayers(string searchQuery)
        {
            return wooDBContext.Players.Where(p => p.Username.Contains(searchQuery));
        }
    }
}