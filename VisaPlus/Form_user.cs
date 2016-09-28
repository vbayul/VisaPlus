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
    public partial class Form_user : Form
    {
        private UserDataSet userDS = new UserDataSet(); 
        public Form_user()
        {
            InitializeComponent();
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_user_Load(object sender, EventArgs e)
        {
            dataGridViewUser.DataSource =  userDS.getDSVisa().Tables[0];
        }
    }
}
