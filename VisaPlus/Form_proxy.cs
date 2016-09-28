using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisaPlus
{
    public partial class Form_proxy : Form
    {
        ProxyDAO proxyDAO = new ProxyDAOImp();
        private ProxyDataSet proxy = new ProxyDataSet();

        public Form_proxy()
        {
            InitializeComponent();
        }

        private void Form_proxy_Load(object sender, EventArgs e)
        {
            dataGridViewProxy.DataSource = proxy.proxyDS().Tables[0];
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxIP.Clear();
            textBoxPort.Clear();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxIP.Text != "" || textBoxPort.Text != "")
            {
                try
                {
                    proxyDAO.saveProxy(textBoxIP.Text, textBoxPort.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка при сохранении данных.");
                }

                dataGridViewProxy.DataSource = proxy.proxyDS().Tables[0];
                textBoxIP.Clear();
                textBoxPort.Clear();
            }
        }
        private void buttonSet_Click(object sender, EventArgs e)
        {
            setProxy(dataGridViewProxy[0, dataGridViewProxy.CurrentCell.RowIndex].Value.ToString());
            /*
            if (dataGridViewProxy.RowCount > 0)
            {
                proxyDAO.setProxy(dataGridViewProxy[0, dataGridViewProxy.CurrentCell.RowIndex].Value.ToString());
                dataGridViewProxy.DataSource = proxy.proxyDS().Tables[0];
            }
            else
            {
                MessageBox.Show("Настройки прокси ещё не внесены.");
            }*/
        }

        private void setProxy(string id)
        {
            if (dataGridViewProxy.RowCount > 0)
            {
                proxyDAO.setProxy(id);
                dataGridViewProxy.DataSource = proxy.proxyDS().Tables[0];
            }
            else
            {
                MessageBox.Show("Настройки прокси ещё не внесены.");
            }
        }

        private void buttonCln_Click(object sender, EventArgs e)
        {
            setProxy("");
        }
    }
}
