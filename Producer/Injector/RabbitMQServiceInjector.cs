
using Producer.Producer;
using Producer.Service;

namespace Producer.Injector
{
    public class RabbitMQServiceInjector : IMessageServiceInjector
    {
        public IProducer getProducer() {
            return new Producer.Producer(new RabbitMQService());
        }
    }
}