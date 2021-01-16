
namespace Domus
{
    public class ThePort
    {
        private string _portname;
        private int _baudrate = 9600;
        private int _readtimeout = 500;
        private int _writetimeout = 200;
        private string _mainportname;

        public string Mainportname
        {
            get { return _mainportname; }
            set { _mainportname = value; }
        }

        public string Portname 
        {
            get { return _portname; }
            set { _portname = value; }
        }

        public int Baudrate
        {
            get { return _baudrate; }
        }

        public int Readtimeout
        {
            get { return _readtimeout; }
        }

        public int Writetimeout
        {
            get { return _writetimeout; }
        }
    }
    class Communication
    {
        string _identity = " im_arduino ";
        string _error = "Failed to read from DHT sensor!";
        string _communicate = "1234567890,";
        string _message = "arduino_come_in";
        
        public string Identity 
        {
            get { return _identity; }
        }

        public string Error
        {
            get { return _error; }
        }

        public string Communicate
        {
            get { return _communicate; }
        }

        public string Message
        {
            get { return _message; }
        }
    }
    class Message
    {
        private string content;
        public string Content { get; set; }
    }
}
