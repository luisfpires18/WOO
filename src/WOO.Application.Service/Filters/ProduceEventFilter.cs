namespace WOO.Application.Service.Filters
{
    using System;
    using Cassandra;
    using Confluent.Kafka;
    using WOO.Application.Service.Pipelines.Interfaces;
    using WOO.Domain.Model.Inputs;

    public class ProduceEventFilter : IFilter<PlayerInput>
    {
        public PlayerInput ExecuteAsync(PlayerInput input)
        {
            // Kafka topic to produce to
            string topic = "dev.player";

            // Kafka producer configuration
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };

            // Create a Kafka producer
            using (var producer = new ProducerBuilder<string, PlayerInput>(config).Build())
            {
                try
                {
                    // Produce a Kafka event
                    var message = new Message<string, PlayerInput>
                    {
                        Key = input.Id.ToString(),
                        Value = input
                    };

                    var deliveryReport = producer.ProduceAsync(topic, message).GetAwaiter().GetResult();

                    // Check if the event was successfully produced
                    if (deliveryReport.Status == PersistenceStatus.Persisted)
                    {
                        Console.WriteLine("Event produced successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to produce event");
                    }
                }
                catch (ProduceException<string, PlayerInput> ex)
                {
                    Console.WriteLine($"Error producing event: {ex.Error.Reason}");
                }
            }

            return input;
        }
    }
}