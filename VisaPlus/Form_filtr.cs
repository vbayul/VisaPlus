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
    public partial class Form_filtr : Form
    {
        public string id = "0", name = "";
        public Form_filtr()
        {
            InitializeComponent();
        }

        private void Form_filtr_Load(object sender, EventArgs e)
        {
            UserDataSet userDS = new UserDataSet();
            dataGridViewManager.DataSource = userDS.getDSUser().Tables[0];
        }

        private void dataGridViewManager_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridViewManager[0, dataGridViewManager.CurrentCell.RowIndex].Value.ToString();
            name = dataGridViewManager[1, dataGridViewManager.CurrentCell.RowIndex].Value.ToString();
            Close();
        }
    }
}
