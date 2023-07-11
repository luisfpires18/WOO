namespace WOO.Application.Kafka.Compression.Interfaces
{
    public interface ICompressionFactory
    {
        ICompressionAlgorithm GetCompressionAlgorithm(AlgorithmEnum algorithmEnum);
    }
}
