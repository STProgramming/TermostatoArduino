using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace Domus
{

    class PortsetConnection
    {
        //gestione delle dipendenze
        Communication MyProtocoll = new Communication();
        static Message MyMessage = new Message();
        public static ThePort Port = new ThePort();   // <- questa è una istanza della classe ThePort (che chiameremo PortsetConnection.Port), che non viene mai valorizzata.

        Thread ThreadRead = new Thread(Read);
        static SerialPort MyPort = new SerialPort();
        string[] ports = SerialPort.GetPortNames();
        
        public void SetUpPort()
        {
            MyPort.PortName = Port.Portname;
            MyPort.BaudRate = Port.Baudrate;
            MyPort.StopBits = StopBits.One;
            MyPort.ReadTimeout = Port.Readtimeout;
            MyPort.WriteTimeout = Port.Writetimeout;
        }

        public static void Read()
        {
            try
            {
                MyMessage.Content = MyPort.ReadExisting();
            }
            catch(TimeoutException)
            {
                //failed to read from the port
            }
        }


        public void CheckIdentity()
        {
            string syntaxPresentation = MyProtocoll.Identity;
            SetUpPort();
            try
            {
                MyPort.Open();
                ThreadRead.Start();
                ThreadRead.Join();
                //controll about content of the message from serial port
                if (MyMessage.Content.All(syntaxPresentation.Contains))
                {
                    Port.Mainportname = Port.Portname;
                    ThreadRead.Abort();
                    MyPort.Close();
                }
                else
                {
                    Port.Mainportname = null;
                    ThreadRead.Abort();
                    MyPort.Open();
                }
            }
            catch (Exception)
            {
                
            }
        }
    }  
}
