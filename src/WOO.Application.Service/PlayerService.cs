namespace WOO.Application.Service
{
    using System.Collections.Generic;
    using WOO.Application.Service.Mappers.Interfaces;
    using WOO.Data.Repository.Interfaces;
    using WOO.Domain.Model;

    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository playerRepository;

        private readonly IPlayerMapper playerMapper;

        public PlayerService(IPlayerRepository playerRepository, IPlayerMapper eventMapper)
        {
            this.playerRepository = playerRepository;
            this.playerMapper = eventMapper;
        }

        public IEnumerable<Player> GetAll()
        {
            var playerList = this.playerRepository.GetAll();

            var result = this.playerMapper.Map(playerList);

            return result;
        }

        public Player? GetPlayerById(int id)
        {
            var @event = this.playerRepository.GetPlayerById(id);

            var result = this.playerMapper.Map(@event);

            return result;
        }

        public IEnumerable<Player> SearchPlayers(string searchQuery)
        {
            var eventList = this.playerRepository.SearchPlayers(searchQuery);

            var result = this.playerMapper.Map(eventList);

            return result;
        }
    }
}