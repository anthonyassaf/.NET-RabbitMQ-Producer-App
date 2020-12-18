using System;

namespace Producer.Service
{
    public interface IMessageService
    {
        void sendMessage(string message, string queueName);
    }
}