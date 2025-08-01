﻿using System;
using Confluent.Kafka;

class Program
{
    static void Main(string[] args)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "chat-consumer-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
        consumer.Subscribe("chat-topic");

        Console.WriteLine("Kafka Chat Consumer Started. Listening...");

        while (true)
        {
            var result = consumer.Consume();
            Console.WriteLine($"[Received] {result.Message.Value}");
        }
    }
}

