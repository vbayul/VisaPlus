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
    public partial class Form_browser : Form
    {
        private string id;

        public Form_browser(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form_browser_Load(object sender, EventArgs e)
        {
            // загнать ссылку в базу
            geckoWebBrowser1.Navigate(@"https://polandonline.vfsglobal.com/poland-ukraine-appointment/(S(lzjdbcyqofk4of45flew25ve))/AppScheduling/AppWelcome.aspx?P=s2x6znRcBRv7WQQK7h4MTjZiPRbOsXKqJzddYBh3qCA=");
        }
    }
}
