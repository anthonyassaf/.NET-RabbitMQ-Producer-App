using RabbitMQ.Client;

namespace Producer
{
    public class Injection
    {
        private IChannel _channel;

        public Injection(IChannel channel)
        {
            this._channel = channel;
        }

        public IModel getChannel()
        {
            return _channel.getChannel();
        }
    }
}