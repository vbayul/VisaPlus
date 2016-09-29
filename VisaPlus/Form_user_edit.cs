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
    public partial class Form_user_edit : Form
    {
        private string id;
        private UserDAO userDAO = new UserDAOImp();
        private User user = new User();
        public Form_user_edit(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Form_user_edit_Load(object sender, EventArgs e)
        {
            if (id != "0")
            {
                user = userDAO.getUser(id);
                textBoxUser.Text = user.getUser();
                textBoxPass.Text = user.getPass();
                textBoxEmail.Text = user.getEmail();
                textBoxEpass.Text = user.getEPass();
                checkBoxAdmin.Checked = Convert.ToBoolean(Convert.ToInt32(user.getType()));
                checkBoxBlock.Checked = Convert.ToBoolean(Convert.ToInt32(user.getStatus()));
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text != "" || textBoxPass.Text != ""
                || textBoxEmail.Text != "" || textBoxEpass.Text != "")
            {
                userDAO.saveUser(user);
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxEdit_TextChanged(object sender, EventArgs e)
        {
            user.setUser(textBoxUser.Text);
            user.setPass(textBoxPass.Text);
            user.setEmail(textBoxEmail.Text);
            user.setEPass(textBoxEpass.Text);
            user.setStatus(Convert.ToInt32(checkBoxBlock.Checked).ToString());
            user.setType(Convert.ToInt32(checkBoxAdmin.Checked).ToString());
        }
    }
}
