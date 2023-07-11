namespace WOO.Application.Kafka.Compression.Interfaces
{
    public interface ICompressionAlgorithm
    {
        byte[] Compress(byte[] message, int compressionLevel);

        byte[] Decompress(byte[] message);
    }
}
