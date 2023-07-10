namespace WOO.Application.Service.Pipelines.Interfaces
{
    public interface IFilter<T>
    {
        T ExecuteAsync(T input);
    }
}