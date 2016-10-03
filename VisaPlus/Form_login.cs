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
    public partial class Form_login : Form
    {
        bool isLogin = false;
        SystemJournal systemJurnal = new SystemJournal();
        UserDAO userDAO = new UserDAOImp();

        public Form_login()
        {
            InitializeComponent();
        }

        private void Form_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLogin)
                Application.Exit();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (checkPass(textBoxPass.Text))// установить всякие параметры аля уровень доступа проверка пароля и т.д.
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Пароль введен не корректно.");
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            comboBoxLogin.DataSource = systemJurnal.getLogin().Tables[0];
            comboBoxLogin.DisplayMember = "username";
            comboBoxLogin.ValueMember = "idusers";
        }

        private bool checkPass(string pass)
        {
            User user = userDAO.getUser(comboBoxLogin.SelectedValue.ToString());
            if (user.getPass() == textBoxPass.Text)
            {
                isLogin = true;
                Param.setAccess(user.getType());
                Param.setUserID(user.getId());
            }
            return isLogin;
        }
    }
}
