using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Gecko.DOM;

namespace VisaPlus
{
    public partial class Form_visa : Form
    {
        private VisaDAO visaDAO = new VisaDAOImp();
        private VisaDataSet visaDS = new VisaDataSet();
        private ProxyDAO proxyDAO = new ProxyDAOImp();
        private Proxy proxy = new Proxy();
        private Setting setting = new Setting();
        private string URL;
        private string idManager = "0";

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
            if (textBoxSearch.Text == "")
            {
                dataGridViewVisa.DataSource = visaDS.getDSVisa(idManager).Tables[0];
            }
            else
            {
                dataGridViewVisa.DataSource = visaDS.searchDSVisa(textBoxSearch.Text, idManager).Tables[0];
            }
            //dataGridViewVisa.DataSource = visaDS.searchDSVisa(textBoxSearch.Text, "0").Tables[0];
        }

        private void Form_visa_Load(object sender, EventArgs e)
        {
            Form_login login = new Form_login();
            login.Owner = this;
            login.ShowDialog(this);
            if (login.DialogResult == DialogResult.OK)
            {
                Param.setUserID("1");
                Param.setAccess("1");
                if (Param.getAccess() == "0")
                {
                    общиеToolStripMenuItem.Visible = false;
                    пользователиToolStripMenuItem.Visible = false;
                    // дописать фильтр по менеджерам
                }
                Param.setConnectionString("database=pass;server=localhost;uid=root;password=njgjkm");
                dataGridViewVisa.DataSource = visaDS.getDSVisa("0").Tables[0];
                URL = setting.getValue("url");
            }
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
                dataGridViewVisa.DataSource = visaDS.searchDSVisa(textBoxSearch.Text, "0").Tables[0];
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
            timer1.Enabled = false;
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
                geckoWebBrowser1.Navigate(URL);
                //geckoWebBrowser1.Navigate(@"2ip.ru");
            }
            else
            {
                label1.Text = "Прокси - нет";
                geckoWebBrowser1.Navigate(URL);
                //geckoWebBrowser1.Navigate(@"2ip.ru");
            }
        }

        private void buttonSearchClean_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            if (textBoxSearch.Text == "")
            {
                dataGridViewVisa.DataSource = visaDS.getDSVisa(idManager).Tables[0];
            }
            else
            {
                dataGridViewVisa.DataSource = visaDS.searchDSVisa(textBoxSearch.Text, idManager).Tables[0];
            }
            //dataGridViewVisa.DataSource = visaDS.getDSVisa("0").Tables[0];
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            geckoWebBrowser1.Reload();
        }

        private void geckoWebBrowser1_Navigating(object sender, Gecko.Events.GeckoNavigatingEventArgs e)
        {

        }

        private void geckoWebBrowser1_Navigating_1(object sender, Gecko.Events.GeckoNavigatingEventArgs e)
        {
            label2.Text = "Загрузка";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ctl00_plhMain_cboPurpose причина обращения
            // ctl00_plhMain_cboVAC количество 

            // ctl00_plhMain_repAppReceiptDetails_ctl01_txtReceiptNumber id номера квитанции

            // ctl00_plhMain_txtEmailID почта 
            // ctl00_plhMain_txtPassword пароль от почты

            var document = geckoWebBrowser1.Document;
            var selectElement = (GeckoSelectElement)document.GetElementById("ctl00_plhMain_cboPurpose");
            selectElement.SelectedIndex = 2;
        }

        private void общиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_setting setting = new Form_setting();
            setting.Owner = this;
            setting.ShowDialog();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            label2.Text = "Стоп";
            timer1.Enabled = false;
            geckoWebBrowser1.Stop();
        }

        private void Form_visa_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void buttonManagerClean_Click(object sender, EventArgs e)
        {
            idManager = "0";
            textBoxManager.Text = "";

            if (textBoxSearch.Text == "")
            {
                dataGridViewVisa.DataSource = visaDS.getDSVisa(idManager).Tables[0];
            }
            else
            {
                dataGridViewVisa.DataSource = visaDS.searchDSVisa(textBoxSearch.Text, idManager).Tables[0];
            }
        }

        private void buttonManager_Click(object sender, EventArgs e)
        {
            Form_filtr filtr = new Form_filtr();
            filtr.Owner = this;
            filtr.ShowDialog();
            idManager = filtr.id;
            textBoxManager.Text = filtr.name;

            if (textBoxSearch.Text == "")
            {
                dataGridViewVisa.DataSource = visaDS.getDSVisa(idManager).Tables[0];
            }
            else
            {
                dataGridViewVisa.DataSource = visaDS.searchDSVisa(textBoxSearch.Text,idManager).Tables[0];
            }
        }
    }
}
