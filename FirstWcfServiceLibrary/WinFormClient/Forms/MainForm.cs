using System;
using System.Windows.Forms;

namespace WinFormClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();            

            this.ActiveControl = tbMessage;
        }


        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string returnString;

            returnString = client.GetData(tbMessage.Text);
            tbMain.Text += returnString + "\r\n";
            tbMessage.Text = "";
        }
    }
}
