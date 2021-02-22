using GeneralInterfaces.IContracts;
using ServerOnWindowsForms.Models;
using ServerOnWindowsForms.Services;
using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace ServerOnWindowsForms
{
    public partial class MainForm : Form
    {
        private ServiceHost _host;

        public MainForm()
        {
            InitializeComponent();

            tbMain.Text = $"{Properties.Resources.NotReady}.\n";
            btnServerStop.Enabled = false;
        }

        /// <summary>
        /// Server start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeverStart_Click(object sender, System.EventArgs e)
        {
            EndpointModel endpoint = new EndpointModel
            {
                Contract = typeof(IFirstContract),
                Binding = new BasicHttpBinding(),                
            };
            endpoint.Adress = new Uri($"http://127.0.0.1:4000/{endpoint.Contract.Name}");

            _host = new ServiceHost(typeof(FirstWcfService));                                   // создание провайдера хостинга с указанием сервиса
            _host.AddServiceEndpoint(endpoint.Contract, endpoint.Binding, endpoint.Adress);     // добавление "конечной точки"
            _host.Open();                                                                       // начало ожидания прихода сообщений

            tbMain.Text = $"{Properties.Resources.Ready}.\n";
            btnServerStop.Enabled = true;
            btnSeverStart.Enabled = false;
        }

        /// <summary>
        /// Server stop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnServerStop_Click(object sender, System.EventArgs e)
        {
            _host?.Close();
            _host = null;

            tbMain.Text = $"{Properties.Resources.NotReady}.\n";
            btnServerStop.Enabled = false;
            btnSeverStart.Enabled = true;
        }
    }
}
