using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Producer.Injector;
using Producer.Producer;
using RabbitMQ.Client;

namespace Producer
{
  public partial class Form1 : Form
  {
    private string queueName = "";
    private IMessageServiceInjector injector;
    private IProducer app;
    
    public Form1()
    {
      InitializeComponent();
      Text = "Producer";
      injector = new RabbitMQServiceInjector();
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
        var message = richTextBox1.Text;
        app = injector.getProducer();
        app.processMessages(message, queueName);
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
