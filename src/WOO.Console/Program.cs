﻿namespace PipelineExample
{
    using System;
    using System.Threading.Tasks;
    using WOO.Application.Service.Filters;
    using WOO.Application.Service.Pipelines;
    using WOO.Domain.Model.Inputs;

    internal class Program
    {
        private static async Task Main(string[] args)
        {
            // Input data
            var input = new PlayerInput { Name = "Luís Pires", Score = 100 };

            // Output the input
            Console.WriteLine("input: " + input.ToString());

            // Create the pipeline
            var pipeline = new PlayerPipeline<PlayerInput>();

            pipeline.AddFilter<RenameFilter>()
                    .AddFilter<ChangeScoreFilter>()
                    .AddFilter<WriteIntoElasticsearchFilter>()
                    .AddFilter<WriteIntoCassandraFilter>()
                    .AddFilter<ProduceEventFilter>();

            // Execute the pipeline
            PlayerInput output = await pipeline.ExecuteAsync(input);

            // Output the result
            Console.WriteLine("Output: " + output.ToString());
        }
    }
}