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
    public partial class Form_select_number : Form
    {
        public string id = "0";
        public Form_select_number()
        {
            InitializeComponent();
        }

        private void Form_select_number_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                id = "1";
            if (radioButton2.Checked)
                id = "2";
            if (radioButton3.Checked)
                id = "3";
        }
    }
}
