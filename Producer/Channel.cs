using RabbitMQ.Client;

namespace Producer
{
    public class Channel : IChannel
    {
        public IModel getChannel()
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost"
            };
            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();
            return channel;
        }
    }
}