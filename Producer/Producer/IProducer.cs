using System;

namespace Producer.Producer
{
    public interface IProducer
    {
        void processMessages(string message, string queueName);
    }
}