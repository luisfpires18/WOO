namespace WOO.Application.Service.Mappers.Interfaces
{
    using WOO.Infrastructure.Crosscutting.Mapping;
    using Domain = WOO.Domain.Model;
    using Data = WOO.Data.Model;

    public interface IPlayerMapper : IMapper<Data.Player, Domain.Player>,
        IMapper<IEnumerable<Data.Player>, IEnumerable<Domain.Player>>
    {
    }
}