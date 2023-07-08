namespace WOO.Application.Service.Filters
{
    using WOO.Application.Service.Pipelines.Interfaces;
    using WOO.Domain.Model.Inputs;

    public class ChangeScoreFilter : IFilter<PlayerInput>
    {
        public PlayerInput Execute(PlayerInput input)
        {
            input.Score *= 2;
            return input;
        }
    }
}