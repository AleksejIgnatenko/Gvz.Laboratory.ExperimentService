using Confluent.Kafka;
using Gvz.Laboratory.ExperimentService.Abstractions;
using Gvz.Laboratory.ExperimentService.Dto;
using System.Text.Json;

namespace Gvz.Laboratory.ExperimentService.Kafka
{
    public class UserKafkaConsumer : IHostedService
    {
        private readonly ILogger<UserKafkaConsumer> _logger;
        private IConsumer<Ignore, string> _consumer;
        private CancellationTokenSource _cts;


        public UserKafkaConsumer(ILogger<UserKafkaConsumer> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "kafka:29092",
                GroupId = "user-group-id",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            _consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            _consumer.Subscribe("users-topic");

            _cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);

            Task.Run(() => ConsumeMessages(_cts.Token));

            return Task.CompletedTask;
        }

        private void ConsumeMessages(CancellationToken cancellationToken)
        {
            try
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    try
                    {
                        var cr = _consumer.Consume(cancellationToken);
                        var userDto = JsonSerializer.Deserialize<UserDto>(cr.Message.Value);
                        _logger.LogInformation($"Consumed message '{userDto.UserName}'.");
                    }
                    catch (ConsumeException e)
                    {
                        _logger.LogError($"Error occurred: {e.Error.Reason}");
                    }
                }
            }
            catch (OperationCanceledException)
            {
                _consumer.Close();
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _cts.Cancel();
            return Task.CompletedTask;
        }
    }
}
