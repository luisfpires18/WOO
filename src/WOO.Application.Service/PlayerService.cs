namespace WOO.Application.Service
{
    using System.Collections.Generic;
    using WOO.Application.Service.Mappers.Interfaces;
    using WOO.Data.Repositories.Interfaces;
    using WOO.Domain.Model;

    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository eventRepository;

        private readonly IPlayerMapper eventMapper;

        public PlayerService(IPlayerRepository eventRepository, IPlayerMapper eventMapper)
        {
            this.eventRepository = eventRepository;
            this.eventMapper = eventMapper;
        }

        public IEnumerable<Player> GetAll()
        {
            var eventList = this.eventRepository.GetAll();

            var result = this.eventMapper.Map(eventList);

            return result;
        }

        public Player? GetPlayerById(int id)
        {
            var @event = this.eventRepository.GetPlayerById(id);

            var result = this.eventMapper.Map(@event);

            return result;
        }

        public IEnumerable<Player> SearchPlayers(string searchQuery)
        {
            var eventList = this.eventRepository.SearchPlayers(searchQuery);

            var result = this.eventMapper.Map(eventList);

            return result;
        }
    }
}