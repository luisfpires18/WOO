namespace WOO.Application.Service.Pipelines
{
    using WOO.Application.Service.Pipelines.Interfaces;

    public interface IPipeline<T>
    {
        Pipeline<T> AddFilter<TFilter>() where TFilter : IFilter<T>, new ();

        T Execute(T input);
    }
}