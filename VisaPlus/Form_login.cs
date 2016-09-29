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
        public Form_login()
        {
            InitializeComponent();
        }

        private void Form_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            // установить всякие параметры аля уровень доступа проверка пароля и т.д.
            this.DialogResult = DialogResult.OK;
        }
    }
}
