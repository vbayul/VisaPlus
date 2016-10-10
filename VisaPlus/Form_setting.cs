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
        private SystemSetting systemSetting = new SystemSetting();
        private SystemJournal systemJurnal = new SystemJournal();

        public Form_setting()
        {
            InitializeComponent();
        }

        private void Form_setting_Load(object sender, EventArgs e)
        {
            textBoxURL.Text = systemSetting.getValue("url");
            comboBoxFill();
            setDeffSettings();
            EmailSetting();
        }

        private void buttonUrlSave_Click(object sender, EventArgs e)
        {
            systemSetting.setValue("url",textBoxURL.Text);
            systemSetting.setValue("emailpassword", textBoxPassword.Text);
            systemSetting.setValue("region", comboBoxRegion.SelectedValue.ToString());
            systemSetting.setValue("purpose",comboBoxPurpose.SelectedValue.ToString());
            systemSetting.setValue("visatype", comboBoxVisaType.SelectedValue.ToString());
            systemSetting.setValue("nationality",comboBoxNationality.SelectedValue.ToString());
            systemSetting.setValue("title", comboBoxTitle.SelectedValue.ToString());

            //
            systemSetting.setValue("smtp", textBoxSMTP.Text);
            systemSetting.setValue("port", textBoxPort.Text);
            systemSetting.setValue("email", textBoxEmail.Text);
            systemSetting.setValue("password", textBoxPass.Text);
            systemSetting.setValue("ssl", Convert.ToInt32(checkBoxSSL.Checked).ToString());
            Close();
        }

        private void comboBoxFill()
        {
            comboBoxRegion.DataSource = systemJurnal.getRegion().Tables[0];
            comboBoxRegion.DisplayMember = "nameregion";
            comboBoxRegion.ValueMember = "idregion";

            comboBoxVisaType.DataSource = systemJurnal.getVisaType().Tables[0];
            comboBoxVisaType.DisplayMember = "namevisatype";
            comboBoxVisaType.ValueMember = "idvisatype";

            comboBoxPurpose.DataSource = systemJurnal.getPurpose().Tables[0];
            comboBoxPurpose.DisplayMember = "namepurposes";
            comboBoxPurpose.ValueMember = "idpurposes";

            comboBoxNationality.DataSource = systemJurnal.getNationality().Tables[0];
            comboBoxNationality.DisplayMember = "nationality";
            comboBoxNationality.ValueMember = "idnationality";

            comboBoxTitle.DataSource = systemJurnal.getTitle().Tables[0];
            comboBoxTitle.DisplayMember = "nametitle";
            comboBoxTitle.ValueMember = "idtitle";
        }

        private void setDeffSettings()
        {
            textBoxPassword.Text = systemSetting.getValue("emailpassword");
            comboBoxRegion.SelectedValue = systemSetting.getValue("region");
            comboBoxPurpose.SelectedValue = systemSetting.getValue("purpose");
            comboBoxVisaType.SelectedValue = systemSetting.getValue("visatype");
            comboBoxNationality.SelectedValue = systemSetting.getValue("nationality");
            comboBoxTitle.SelectedValue = systemSetting.getValue("title");
        }

        private void EmailSetting()
        {
            textBoxSMTP.Text = systemSetting.getValue("smtp");
            textBoxPort.Text = systemSetting.getValue("port");
            textBoxEmail.Text = systemSetting.getValue("email");
            textBoxPass.Text = systemSetting.getValue("password");
            checkBoxSSL.Checked = Convert.ToBoolean(Int32.Parse(systemSetting.getValue("ssl")));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}