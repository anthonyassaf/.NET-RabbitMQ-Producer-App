using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RabbitMQ.Client;

namespace Producer
{
  public partial class Form1 : Form
  {
    private string queueName = "";
    public Form1()
    {
      InitializeComponent();
      Text = "Producer";
    }


    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      
    }


    private void button1_Click(object sender, EventArgs e)
    {
      if (queueName == "")
      {
        MessageBox.Show("Please enter a queue name before sending a message");
      }
      else
      {
        Injection cs = new Injection(new Channel());
        var channel = cs.getChannel();
        channel.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: false,
          arguments: null);
        string message = richTextBox1.Text;
        var body = Encoding.UTF8.GetBytes(message);
        channel.BasicPublish(exchange: "", routingKey: queueName, basicProperties: null, body: body);
        
        MessageBox.Show("Sent : " + message, "Message Sent");
      }
            
      richTextBox1.Clear(); 
    }

    private void button2_Click(object sender, EventArgs e)
    {
      queueName = textBox1.Text;
    }


    private void button3_Click(object sender, EventArgs e)
    {
      System.Windows.Forms.Application.Exit();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
      
    }
  }
}
