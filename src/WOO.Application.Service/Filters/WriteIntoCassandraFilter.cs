﻿namespace WOO.Application.Service.Filters
{
    using System;
    using System.Threading.Tasks;
    using Cassandra;
    using WOO.Application.Service.Pipelines.Interfaces;
    using WOO.Domain.Model.Inputs;

    public class WriteIntoCassandraFilter : IFilter<PlayerInput>
    {
        public Task<PlayerInput> ExecuteAsync(PlayerInput input)
        {
            // Connect to Cassandra
            var cluster = Cluster.Builder()
                .AddContactPoint("localhost")
                .Build();

            var session = cluster.Connect();

            // Create a keyspace
            string keyspaceName = "mykeyspace";
            string replicationStrategy = "SimpleStrategy";
            int replicationFactor = 1;

            string createKeyspaceQuery = $"CREATE KEYSPACE IF NOT EXISTS {keyspaceName} WITH REPLICATION = {{ 'class' : '{replicationStrategy}', 'replication_factor' : {replicationFactor} }}";
            session.Execute(createKeyspaceQuery);

            Console.WriteLine("Keyspace created successfully!");

            session = cluster.Connect(keyspaceName); // Replace "mykeyspace" with your keyspace name

            // Create a table if it doesn't exist
            session.Execute("CREATE TABLE IF NOT EXISTS player (id UUID PRIMARY KEY, name TEXT, score INT)");

            // Generate a new UUID for the record
            input.Id = Guid.NewGuid();

            // Insert a record into the table
            var insertStatement = session.Prepare("INSERT INTO player (id, name, score) VALUES (?, ?, ?)");
            var insertBoundStatement = insertStatement.Bind(input.Id, input.Name, input.Score);
            session.Execute(insertBoundStatement);

            Console.WriteLine("Record inserted successfully!");

            // Clean up
            session.Dispose();
            cluster.Dispose();

            return Task.FromResult(input);
        }
    }
}