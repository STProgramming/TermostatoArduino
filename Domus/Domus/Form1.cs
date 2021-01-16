using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace Domus
{
    public partial class Form1 : Form
    {
        //gestione delle dipendenze
        Thread readThread = new Thread(Read);
        SerialPort MyPort = new SerialPort();
        string message;
        string mainport;
        string GreetingProtocoll = " im_arduino ";
        string DataProtocoll = "1234567890. ";

        public string Messsage
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //inizializzazione dell'oggett parametri standard immessi per la connessione alla porta di cui abbiamo bisongo
            MyPort.BaudRate = 9600; //implementazione del baudrate a 9600;
            MyPort.WriteTimeout = 200;
            MyPort.ReadTimeout = 1100;
            StatusText.Text = "I'm searching for the sensor";
            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports)
            {
                MyPort.PortName = port;
                SearcherResult.Text = "Search in all port available " + port;
                MyPort.Open();
                readThread.Start();
                if (message.All(GreetingProtocoll.Contains) || message.All(DataProtocoll.Contains))
                {
                    string mainport = MyPort.PortName;
                    StatusText.Text = "Enstablish connection with the sensor";
                }
                else if(string.IsNullOrEmpty(message))
                {
                    StatusText.Text = "Could not find the sensor retry";
                }
                readThread.Join();
                MyPort.Close();
            }
        }
        public static void Read()
        {
            Form1 myObj = new Form1();
            try
            {
                myObj.Messsage = myObj.MyPort.ReadLine();
            }
            catch (TimeoutException) { }
        }
    }
}
