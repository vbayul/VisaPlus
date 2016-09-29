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
    public partial class Form_setting : Form
    {
        Setting setting = new Setting();

        public Form_setting()
        {
            InitializeComponent();
        }

        private void Form_setting_Load(object sender, EventArgs e)
        {
            textBox1.Text = setting.getValue("url");
        }

        private void buttonUrlSave_Click(object sender, EventArgs e)
        {
            setting.setValue(textBox1.Text, "url");
        }

    }
}
