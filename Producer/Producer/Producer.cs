using System;
using System.IO;
using Producer.Service;
using RabbitMQ.Client;

namespace Producer.Producer
{
    public class Producer : IProducer
    {
        private IMessageService service;
        
        public Producer(IMessageService svc) {
            this.service = svc;
        }

        public Producer() { }

        public void setService(IMessageService service) {
            this.service = service;
        }
        
        public void processMessages(string message, string queueName) {
            this.service.sendMessage(message, queueName);
        }
        
    }
}