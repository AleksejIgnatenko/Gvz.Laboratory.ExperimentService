namespace Gvz.Laboratory.ExperimentService.Abstractions
{
    public interface IUserKafkaConsumer
    {
        Task StartConsuming(string topic);
    }
}