using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VisaPlus
{
    public partial class Form_visa : Form
    {
        private VisaDAO visaDAO = new VisaDAOImp();
        private VisaDataSet visaDS = new VisaDataSet();
        private ProxyDAO proxyDAO = new ProxyDAOImp();
        private Proxy proxy = new Proxy();

        public Form_visa()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Form_visa_edit addVisa = new Form_visa_edit("0");
            addVisa.Owner = this;
            addVisa.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewVisa.DataSource = visaDS.searchDSVisa(textBoxSearch.Text).Tables[0];
        }

        private void Form_visa_Load(object sender, EventArgs e)
        {
            Param.setUserID("1");
            Param.setConnectionString("database=pass;server=localhost;uid=root;password=njgjkm");
            dataGridViewVisa.DataSource = visaDS.getDSVisa().Tables[0];
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewVisa.Rows.Count > 0)
            {
                Form_visa_edit editVisa = new Form_visa_edit(dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString());
                editVisa.Owner = this;
                editVisa.ShowDialog();
            }
        }

        private void dataGridViewVisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewVisa.Rows.Count > 0)
            {
                Form_browser editVisa = new Form_browser(dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString());
                editVisa.Owner = this;
                editVisa.ShowDialog();
            }
            /*
            proxy = proxyDAO.getProxy();
            label2.Text = "Загрузка";
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
                //geckoWebBrowser1.Navigate(@"2ip.ru");
            }
             */
        }

        private void проксиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_proxy proxy = new Form_proxy();
            proxy.Owner = this;
            proxy.ShowDialog();
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dataGridViewVisa.DataSource = visaDS.searchDSVisa(textBoxSearch.Text).Tables[0];
            }
        }

        private void buttonProxy_Click(object sender, EventArgs e)
        {
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

        private void geckoWebBrowser1_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {

            if (geckoWebBrowser1.Document.Body.TextContent.ToString() == "The service is unavailable.")
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                label2.Text = "Готово";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate(@"https://polandonline.vfsglobal.com/poland-ukraine-appointment/(S(lzjdbcyqofk4of45flew25ve))/AppScheduling/AppWelcome.aspx?P=s2x6znRcBRv7WQQK7h4MTjZiPRbOsXKqJzddYBh3qCA=");
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_user user = new Form_user();
            user.Owner = this;
            user.ShowDialog();
        }

        private void buttonWeb_Click(object sender, EventArgs e)
        {
            proxy = proxyDAO.getProxy();
            label2.Text = "Загрузка";
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
                label1.Text = "Прокси - нет";
                geckoWebBrowser1.Navigate(@"https://polandonline.vfsglobal.com/poland-ukraine-appointment/(S(lzjdbcyqofk4of45flew25ve))/AppScheduling/AppWelcome.aspx?P=s2x6znRcBRv7WQQK7h4MTjZiPRbOsXKqJzddYBh3qCA=");
                //geckoWebBrowser1.Navigate(@"2ip.ru");
            }
        }
    }
}
