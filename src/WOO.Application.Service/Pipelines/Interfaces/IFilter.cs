namespace WOO.Application.Service.Pipelines.Interfaces
{
    public interface IFilter<T>
    {
        T Execute(T input);
    }
}