using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gecko;

namespace VisaPlus
{
    public partial class Form_browser : Form
    {
        private string id;
        private ProxyDAO proxyDAO = new ProxyDAOImp();
        private Proxy proxy = new Proxy();

        public Form_browser(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form_browser_Load(object sender, EventArgs e)
        {
            proxy = proxyDAO.getProxy();

            if (proxy.getProxyIP() != null)
            {
                label1.Text = "Прокси - http://" + proxy.getProxyIP() + ":" + proxy.getProxyPort();
                Gecko.GeckoPreferences.User["network.proxy.type"] = 1;
                Gecko.GeckoPreferences.User["network.proxy.http"] = proxy.getProxyIP();
                Gecko.GeckoPreferences.User["network.proxy.http_port"] = Convert.ToInt32(proxy.getProxyPort());
                Gecko.GeckoPreferences.User["network.proxy.ssl"] = proxy.getProxyIP();
                Gecko.GeckoPreferences.User["network.proxy.ssl_port"] = Convert.ToInt32(proxy.getProxyPort());
                geckoWebBrowser1.Navigate(@"https://polandonline.vfsglobal.com/poland-ukraine-appointment/(S(lzjdbcyqofk4of45flew25ve))/AppScheduling/AppWelcome.aspx?P=s2x6znRcBRv7WQQK7h4MTjZiPRbOsXKqJzddYBh3qCA=");
            }
            else
            {
                label1.Text = "Прокси - ";
                geckoWebBrowser1.Navigate(@"https://polandonline.vfsglobal.com/poland-ukraine-appointment/(S(lzjdbcyqofk4of45flew25ve))/AppScheduling/AppWelcome.aspx?P=s2x6znRcBRv7WQQK7h4MTjZiPRbOsXKqJzddYBh3qCA=");
            }
        }

        private void geckoWebBrowser1_ProgressChanged(object sender, Gecko.GeckoProgressEventArgs e)
        {
            
            progressBar1.Maximum = (int)e.MaximumProgress;
            try
            {
                progressBar1.Value = (int)e.CurrentProgress;
            }
            catch (Exception)
            {
            }
        }
        private void buttonProxy_Click(object sender, EventArgs e)
        {
            Form_proxy proxy = new Form_proxy();
            proxy.Owner = this;
            proxy.ShowDialog();
        }
    }
}
