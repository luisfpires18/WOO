namespace WOO.Application.Service
{
    using System.Collections.Generic;
    using WOO.Domain.Model;

    public interface IPlayerService
    {
        IEnumerable<Player> GetAll();

        Player? GetPlayerById(int id);

        IEnumerable<Player> SearchPlayers(string searchQuery);
    }
}