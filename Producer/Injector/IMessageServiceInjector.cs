using Producer.Producer;

namespace Producer.Injector
{
    public interface IMessageServiceInjector
    { 
        IProducer getProducer();
    }
}