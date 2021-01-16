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
        string message;//
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
            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports)
            {
                MyPort.PortName = port;
                //una volta nominata la porta possso porcede alla connessione e alla cattura
                if(MyPort.IsOpen)
                {
                    //ascolta la porta
                    readThread.Start();
                    
                }
                else
                {
                    try
                    {
                        MyPort.Open();
                    }
                    catch
                    {
                        //here some error's text
                    }
                }
            }
        }
        public static void Read()
        {
            Form1 myObj = new Form1();
            try
            {
                message = myObj.MyPort.ReadLine();
            }
            catch (TimeoutException) { }
        }
    }
}
