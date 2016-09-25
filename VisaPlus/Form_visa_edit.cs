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
    public partial class Form_visa_edit : Form
    {
        private VisaDAO visaDAO = new VisaDAOImp();
 
        private string id;
        public Form_visa_edit(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void Form_visa_edit_Load(object sender, EventArgs e)
        {
            Visa visa = visaDAO.getVisa(id);
            textBoxClientName.Text = visa.getClientName();
            textBoxClientTicket.Text = visa.getClientTicket();
            checkBoxPass.Checked = Convert.ToBoolean(Convert.ToInt32(visa.getClientStatus()));
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (id == "0")
            {
                if (textBoxClientName.Text != "" || textBoxClientTicket.Text != "")
                {
                    Visa visa = new Visa(textBoxClientName.Text, textBoxClientTicket.Text, "0");

                    if (visaDAO.addVisa(visa))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при сохранении данных.");
                    }
                }
            }
            else
            {
                if (textBoxClientName.Text != "" || textBoxClientTicket.Text != "")
                {
                    Visa visa = new Visa(id,textBoxClientName.Text, textBoxClientTicket.Text, Convert.ToInt32(checkBoxPass.Checked).ToString());

                    if (visaDAO.saveVisa(visa))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при сохранении данных.");
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
