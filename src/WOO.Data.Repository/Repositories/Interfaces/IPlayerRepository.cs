namespace WOO.Data.Repository.Interfaces
{
    using WOO.Data.Repository.Model;

    public interface IPlayerRepository
    {
        IEnumerable<Player> GetAll();

        Player? GetPlayerById(int id);

        IEnumerable<Player> SearchPlayers(string searchQuery);
    }
}