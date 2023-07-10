namespace WOO.Application.Service.Pipelines
{
    using WOO.Application.Service.Pipelines.Interfaces;

    public class Pipeline<T> : IPipeline<T>
    {
        private readonly List<IFilter<T>> filters;

        public Pipeline()
        {
            filters = new List<IFilter<T>>();
        }

        public Pipeline<T> AddFilter<TFilter>()
            where TFilter : IFilter<T>, new()
        {
            filters.Add(new TFilter());

            return this;
        }

        public T Execute(T input)
        {
            T result = input;

            foreach (var filter in filters)
            {
                result = filter.ExecuteAsync(result);
            }

            return result;
        }
    }
}