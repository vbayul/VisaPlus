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
        private User userSave = new User();
        private UserDAO userDAO = new UserDAOImp();
        public Form_user_edit(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Form_user_edit_Load(object sender, EventArgs e)
        {
            if (id != "0")
            {
                User user = userDAO.getUser(id);

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
                if (id != "0")
                {
                    if (userDAO.saveUser(userSave))
                    {
                        Close();
                    }
                }
                else
                {
                    if (userDAO.addUser(userSave))
                    {
                        Close();
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxEdit_TextChanged(object sender, EventArgs e)
        {
            userSave.setId(id);
            userSave.setUser(textBoxUser.Text);
            userSave.setPass(textBoxPass.Text);
            userSave.setEmail(textBoxEmail.Text);
            userSave.setEPass(textBoxEpass.Text);
            userSave.setStatus(Convert.ToInt32(checkBoxBlock.Checked).ToString());
            userSave.setType(Convert.ToInt32(checkBoxAdmin.Checked).ToString());
        }
    }
}
