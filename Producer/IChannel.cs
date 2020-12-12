using RabbitMQ.Client;

namespace Producer
{
    public interface IChannel
    {
        IModel getChannel();
    }
}