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
        static SerialPort MyPort = new SerialPort();
        string message;
        string mainport;
        string GreetingProtocoll = " im_arduino ";
        string DataProtocoll = "1234567890. ";

        public string Mainport
        {
            get
            {
                return mainport;
            }    
            set
            {
                mainport = value;
            }
        }

        public string Message
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
            readThread.Start();
            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports)
            {
                MyPort.PortName = port;
                MyPort.Open();
                SearcherResult.Text = "Search in all port available " + port + " in the pc."; 
                
                if(string.IsNullOrEmpty(Message))
                {
                    Mainport = null;
                }
                else
                {
                    Mainport = port;
                }
                readThread.Join();
                MyPort.Close();
            }
            if(string.IsNullOrEmpty(mainport))
            {
                StatusText.Text = "It seems the sensor is not linked to the PC.";
                SearcherResult.Visible = false;
            }
            else
            {
                StatusText.Text = "You will redirect to the application";
                SearcherResult.Text = "Enstablish communication to " + mainport;
            }
        }
        public static void Read()
        {
            Form1 myObj = new Form1();
            var message = myObj.Message;
            try
            {
                message = MyPort.ReadLine();
            }
            catch (TimeoutException) {  }
        }
    }
}
