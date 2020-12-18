using System;
using System.Text;
using RabbitMQ.Client;

namespace Producer.Service
{
    public class RabbitMQService : IMessageService
    {
        public void sendMessage(string message, string queueName)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using(var connection = factory.CreateConnection())
            using(var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "hello", durable: false, exclusive: false, autoDelete: false, arguments: null);
                
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "", routingKey: queueName, basicProperties: null, body: body);
                Console.WriteLine(" [x] Sent {0}", message);
            }
            
        }
    }
}