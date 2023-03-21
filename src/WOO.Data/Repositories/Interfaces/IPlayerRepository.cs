namespace WOO.Data.Repositories.Interfaces
{
    using WOO.Data.Model;

    public interface IPlayerRepository
    {
        IEnumerable<Player> GetAll();

        Player? GetPlayerById(int id);

        IEnumerable<Player> SearchPlayers(string searchQuery);
    }
}