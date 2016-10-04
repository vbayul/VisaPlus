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
        private SystemJournal systemJurnal = new SystemJournal();
        private SystemSetting systemSetting = new SystemSetting();
        private VisaDAO visaDAO = new VisaDAOImp();
        private string id;

        public Form_visa_edit(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void Form_visa_edit_Load(object sender, EventArgs e)
        {
            comboBoxFill();
            if (id != "0")
            {
                //дописать заполнение полей формы
                Visa visa = visaDAO.getVisa(id);
                fillFildsByVisa(visa);
            }
            else
            {
                setDeffSettings();
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Visa visa = new Visa();
            visa = fillVisaByFilds(visa);
            if (id == "0")
            {
                if (textBoxLastName.Text != "" || textBoxFirstName.Text != "" || textBoxEmail.Text != "")
                {
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
                if (textBoxLastName.Text != "" || textBoxFirstName.Text != "")
                {
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

        private void fillFildsByVisa(Visa visa)
        {
            maskedTextBoxVisitDate.Text = visa.getvisitdate();
            checkBoxSatus.Checked = Convert.ToBoolean(Convert.ToInt32(visa.getstatus()));
            comboBoxRegion.SelectedValue = visa.getregion();
            comboBoxTitle.SelectedValue = visa.gettitle();
            textBoxFirstName.Text = visa.getfirstname();
            textBoxLastName.Text = visa.getlastname();
            maskedTextBoxDOB.Text = visa.getdob();
            textBoxEmail.Text = visa.getemail();
            textBoxPassword.Text = visa.getpassword();
            textBoxPassport.Text = visa.getpassport();
            maskedTextBoxPassportExpire.Text = visa.getpassportexpire();
            textBoxClientTicket.Text = visa.getclientticket();
            comboBoxVisaType.SelectedValue = visa.getvisatype();
            comboBoxNationality.SelectedValue = visa.getnationality();
            comboBoxPurpose.SelectedValue = visa.getpurpose();
            numericUpDownPersons.Value = Convert.ToDecimal(visa.getpersons());
            numericUpDownKids.Value = Convert.ToDecimal(visa.getkids());
            numericUpDownPayed.Value = Convert.ToDecimal(visa.getpayed());
            numericUpDownTravelLength.Value = Convert.ToDecimal(visa.gettravellength());
            if (visa.getnearestdate() == "1")
                radioButtonNearestDate1.Checked = true;
            else
                radioButtonNearestDate2.Checked = true;
        }

        private Visa fillVisaByFilds(Visa visa)
        {
            if (id != "0")
                visa.setId(id);
            visa.setvisitdate(maskedTextBoxVisitDate.Text);
            visa.setstatus(Convert.ToInt32(checkBoxSatus.Checked).ToString());
            visa.setregion(comboBoxRegion.SelectedValue.ToString());
            visa.settitle(comboBoxTitle.SelectedValue.ToString());
            visa.setfirstname(textBoxFirstName.Text);
            visa.setlastname(textBoxLastName.Text);
            visa.setdob(maskedTextBoxDOB.Text);
            visa.setemail(textBoxEmail.Text);
            visa.setpassword(textBoxPassword.Text);
            visa.setpassport(textBoxPassport.Text);
            visa.setpassportexpire(maskedTextBoxPassportExpire.Text);
            visa.setclientticket(textBoxClientTicket.Text);
            visa.setvisatype(comboBoxVisaType.SelectedValue.ToString());
            visa.setnationality(comboBoxNationality.SelectedValue.ToString());
            visa.setpurpose(comboBoxPurpose.SelectedValue.ToString());
            visa.setpersons(numericUpDownPersons.Value.ToString());
            visa.setkids(numericUpDownKids.Value.ToString());
            visa.setpayed(numericUpDownPayed.Value.ToString());
            visa.settravellength(numericUpDownTravelLength.Value.ToString());
            if (radioButtonNearestDate1.Checked == true)
                visa.setnearestdate("1");
            else
                visa.setnearestdate("0");
            return visa;
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
