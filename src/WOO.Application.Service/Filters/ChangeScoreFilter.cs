namespace WOO.Application.Service.Filters
{
    using System.Threading.Tasks;
    using WOO.Application.Service.Pipelines.Interfaces;
    using WOO.Domain.Model.Inputs;

    public class ChangeScoreFilter : IFilter<PlayerInput>
    {
        public Task<PlayerInput> ExecuteAsync(PlayerInput input)
        {
            input.Score *= 2;
            return Task.FromResult(input);
        }
    }
}