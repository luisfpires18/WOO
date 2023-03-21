namespace WOO.Application.Service.Mappers
{
    using WOO.Application.Service.Mappers.Interfaces;
    using Data = WOO.Data.Model;
    using Domain = WOO.Domain.Model;

    public class PlayerMapper : IPlayerMapper
    {
        public Domain.Player Map(Data.Player source)
        {
            if (source == null)
            {
                return null;
            }

            var result = new Domain.Player
            {
            };

            return result;
        }

        public IEnumerable<Domain.Player> Map(IEnumerable<Data.Player> source)
        {
            if (source == null || !source.Any())
            {
                return new List<Domain.Player>();
            }

            var result = source
                .Where(x => x != null)
                .Select(x => this.Map(x))
                .ToList();

            return result;
        }
    }
}