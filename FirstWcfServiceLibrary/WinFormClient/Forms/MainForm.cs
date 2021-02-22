using GeneralInterfaces.IContracts;
using System;
using System.ServiceModel;
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

        /// <summary>
        /// Обращение к серверу на WinServices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string returnString;

            returnString = client.GetData(tbMessage.Text);
            tbMain.Text += returnString + "\r\n";
            tbMessage.Text = "";
        }

        /// <summary>
        /// Обращение к серверу на WinForms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMessageToWinFormServer_Click(object sender, EventArgs e)
        {

            Uri adress = new Uri($"http://127.0.0.1:4000/IContract");       // где ожидать входящие сообщения
            BasicHttpBinding binding = new BasicHttpBinding();              // указания, как обмениваться сообщениями
            EndpointAddress endpoint = new EndpointAddress(adress);

            // Создание фабрики каналов
            ChannelFactory<IFirstContract> channelFactory = new ChannelFactory<IFirstContract>(binding, endpoint);

            // Использование фабрики для создания канала (прокси)
            IFirstContract channel = channelFactory.CreateChannel();

            // Использование канала для отправки сообщения 
            try
            {
                string returnString = channel.GetData(tbMessage.Text);
                tbMain.Text += returnString + "\r\n";
            }
            catch (Exception)
            {
                tbMain.Text += "Сервер не работает";
            }
            tbMessage.Text = "";
        }
    }
}
