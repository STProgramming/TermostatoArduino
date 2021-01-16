using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Domus
{
    public partial class Form1 : Form
    {
        //gestione delle dipendenze
        PortsetConnection Myconnection = new PortsetConnection();
        public ThePort Port { get { return PortsetConnection.Port; } }

        readonly Message Content = new Message();

        public Form1()
        {
            InitializeComponent();
        }

        private void ManuallyBtn_Click(object sender, EventArgs e)
        {
            AllPortsBox.Visible = true;

        }
        private void AllPortsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AllPortsBox.SelectedIndex>-1)
            {
                AgreeBtn.Visible = true;
                //StatusDialogue.Text = (AllPortsBox.Text);
            }
            else
            {
                AgreeBtn.Visible = false;
            }
        }

        private void AgreeBtn_Click(object sender, EventArgs e)
        {
            Port.Portname = AllPortsBox.Text;
            StatusDialogue.Text = ("Enstablish communication with Port " + Port.Portname );
            Myconnection.CheckIdentity();
            //progressBar1.Value = 25;
        }

    }
}
