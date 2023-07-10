namespace WOO.Application.Service.Filters
{
    using WOO.Application.Service.Pipelines.Interfaces;
    using WOO.Domain.Model.Inputs;

    public class RenameFilter : IFilter<PlayerInput>
    {
        public PlayerInput ExecuteAsync(PlayerInput input)
        {
            input.Name = input.Name.ToUpper();
            input.Score += 10;
            return input;
        }
    }
}