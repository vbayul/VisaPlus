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
        private string id;
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
            try
            {

                
            }
            catch(Exception)
            {
                MessageBox.Show("Произошла ощибка при сохранении данных.");
            }
            proxy.proxyDS();
            // процедура сохарнения настроек прокси
            textBoxIP.Clear();
            textBoxPort.Clear();
        }
        private void buttonSet_Click(object sender, EventArgs e)
        {
            if (dataGridViewProxy.RowCount > 0)
            {

            }
            else
            {
                MessageBox.Show("Настройки прокси ещё не внесены");
            }
        }

    }
}
