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
            try
            {
                dataGridViewVisa.DataSource = visaDS.getDSVisa().Tables[0];
            }
            catch(Exception)
            {
                MessageBox.Show("Ошибка соединени с базой данных");
            }
        }

        private void Form_visa_Load(object sender, EventArgs e)
        {
            User.setUserID("1");
            User.setConnectionString("database=pass;server=localhost;uid=root;password=njgjkm");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form_visa_edit editVisa = new Form_visa_edit(dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString());
            editVisa.Owner = this;
            editVisa.ShowDialog();
        }

        private void dataGridViewVisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_browser newVisa = new Form_browser("0");
            newVisa.Owner = this;
            newVisa.ShowDialog();
        }

        private void проксиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_proxy proxy = new Form_proxy();
            proxy.Owner = this;
            proxy.ShowDialog();
        }
    }
}
