namespace PipelineExample
{
    using System;
    using WOO.Application.Service.Filters;
    using WOO.Application.Service.Pipelines;
    using WOO.Domain.Model.Inputs;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Input data
            var input = new PlayerInput { Name = "Luís Pires", Score = 100 };

            // Output the input
            Console.WriteLine("input: " + input.ToString());

            // Create the pipeline
            var pipeline = new PlayerPipeline<PlayerInput>();

            pipeline.AddFilter<RenameFilter>()
                    .AddFilter<ChangeScoreFilter>();

            // Execute the pipeline
            PlayerInput output = pipeline.Execute(input);

            // Output the result
            Console.WriteLine("Output: " + output.ToString());
        }
    }
}