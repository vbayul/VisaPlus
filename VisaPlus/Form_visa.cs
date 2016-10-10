using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Gecko;
using Gecko.DOM;

namespace VisaPlus
{
    public partial class Form_visa : Form
    {
        private Form_visa_edit editVisa;
        private Form_select_number selectNumber;
        private VisaDAO visaDAO = new VisaDAOImp();
        private VisaDataSet visaDS = new VisaDataSet();
        private ProxyDAO proxyDAO = new ProxyDAOImp();
        private Proxy proxy = new Proxy();
        private SystemSetting systemSetting = new SystemSetting();
        private string URL;
        private string idManager = "0";
        private Visa visaInput = new Visa();
        private bool stop =false;

        public Form_visa()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Form_visa_edit addVisa = new Form_visa_edit("0");
            addVisa.Owner = this;
            addVisa.ShowDialog();
            dataGridViewVisa.DataSource = visaDS.getDSVisa(idManager).Tables[0];
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                dataGridViewVisa.DataSource = visaDS.getDSVisa(idManager).Tables[0];
                RowsColor();
            }
            else
            {
                dataGridViewVisa.DataSource = visaDS.searchDSVisa(textBoxSearch.Text, idManager).Tables[0];
                RowsColor();
            }
            //dataGridViewVisa.DataSource = visaDS.searchDSVisa(textBoxSearch.Text, "0").Tables[0];
        }

        private void Form_visa_Load(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage();
            tabPage.Tag = "http://stackoverflow.com";
            tabPage.ToolTipText = "ToolTipText";
            tabPage.Text = "Text";
            // запрет кеширования страницы.
            Gecko.GeckoPreferences.User["browser.cache.disk.enable"] = false;
            Gecko.GeckoPreferences.User["browser.cache.memory.enable"] = false;
            Param.setConnectionString("database=" + Properties.Settings.Default.DBURL + ";server=localhost;uid=root;password=njgjkm");
            
            Form_login login = new Form_login();
            login.Owner = this;
            login.ShowDialog(this);
            if (login.DialogResult == DialogResult.OK)
            {
                if (Param.getAccess() == "0")
                {
                    общиеToolStripMenuItem.Visible = false;
                    пользователиToolStripMenuItem.Visible = false;
                    textBoxManager.Visible = false;
                    buttonManager.Visible = false;
                    buttonManagerClean.Visible = false;
                    // дописать фильтр по менеджерам
                }
                dataGridViewVisa.DataSource = visaDS.getDSVisa(idManager).Tables[0];
                RowsColor();
                URL = systemSetting.getValue("url");
                
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewVisa.Rows.Count > 0)
            {
                editVisa = new Form_visa_edit(dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString());
                editVisa.Owner = this;
                editVisa.ShowDialog();
            }
            dataGridViewVisa.DataSource = visaDS.getDSVisa(idManager).Tables[0];
        }

        private void dataGridViewVisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewVisa.Rows.Count > 0)
            {
                editVisa = new Form_visa_edit(dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString());
                editVisa.Owner = this;
                editVisa.ShowDialog();
            }
        }

        private void проксиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_proxy proxy = new Form_proxy();
            proxy.Owner = this;
            proxy.ShowDialog();
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (textBoxSearch.Text == "")
                {
                    dataGridViewVisa.DataSource = visaDS.getDSVisa(idManager).Tables[0];
                }
                else
                {
                    dataGridViewVisa.DataSource = visaDS.searchDSVisa(textBoxSearch.Text, idManager).Tables[0];
                }
            }
        }

        private void geckoWebBrowser1_ProgressChanged(object sender, Gecko.GeckoProgressEventArgs e)
        {
            progressBar1.Maximum = (int)e.MaximumProgress;
            try
            {
                progressBar1.Value = (int)e.CurrentProgress;
            }
            catch (Exception)
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Загрузка";
            geckoWebBrowser1.Reload();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_user user = new Form_user();
            user.Owner = this;
            user.ShowDialog();
        }

        private void buttonWeb_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            proxy = proxyDAO.getProxy();
            label2.Text = "Загрузка";
            if (proxy.getProxyIP() != null)
            {
                label1.Text = "Прокси - http://" + proxy.getProxyIP() + ":" + proxy.getProxyPort();
                Gecko.GeckoPreferences.User["network.proxy.type"] = 1;
                Gecko.GeckoPreferences.User["network.proxy.http"] = proxy.getProxyIP();
                Gecko.GeckoPreferences.User["network.proxy.http_port"] = Convert.ToInt32(proxy.getProxyPort());
                Gecko.GeckoPreferences.User["network.proxy.ssl"] = proxy.getProxyIP();
                Gecko.GeckoPreferences.User["network.proxy.ssl_port"] = Convert.ToInt32(proxy.getProxyPort());
                geckoWebBrowser1.Navigate(URL);
                //geckoWebBrowser1.Navigate(@"2ip.ru");
            }
            else
            {
                label1.Text = "Прокси - нет";
                geckoWebBrowser1.Navigate(URL);
                //geckoWebBrowser1.Navigate(@"2ip.ru");
            }
        }

        private void buttonSearchClean_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            if (textBoxSearch.Text == "")
            {
                dataGridViewVisa.DataSource = visaDS.getDSVisa(idManager).Tables[0];
                RowsColor();
            }
            else
            {
                dataGridViewVisa.DataSource = visaDS.searchDSVisa(textBoxSearch.Text, idManager).Tables[0];
                RowsColor();
            }
            //dataGridViewVisa.DataSource = visaDS.getDSVisa("0").Tables[0];
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.Reload();
        }

        private void geckoWebBrowser1_Navigating_1(object sender, Gecko.Events.GeckoNavigatingEventArgs e)
        {
            label2.Text = "Загрузка";
        }

        private void общиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_setting setting = new Form_setting();
            setting.Owner = this;
            setting.ShowDialog();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            label2.Text = "Стоп";
            stop = true;
            //geckoWebBrowser1.Stop();
            timer1.Enabled = false;
        }

        private void buttonManagerClean_Click(object sender, EventArgs e)
        {
            idManager = "0";
            textBoxManager.Text = "";

            if (textBoxSearch.Text == "")
            {
                dataGridViewVisa.DataSource = visaDS.getDSVisa(idManager).Tables[0];
                RowsColor();
            }
            else
            {
                dataGridViewVisa.DataSource = visaDS.searchDSVisa(textBoxSearch.Text, idManager).Tables[0];
                RowsColor();
            }
        }

        private void buttonManager_Click(object sender, EventArgs e)
        {
            Form_filtr filtr = new Form_filtr();
            filtr.Owner = this;
            filtr.ShowDialog();
            idManager = filtr.id;
            textBoxManager.Text = filtr.name;

            if (textBoxSearch.Text == "")
            {
                dataGridViewVisa.DataSource = visaDS.getDSVisa(idManager).Tables[0];
                RowsColor();
            }
            else
            {
                dataGridViewVisa.DataSource = visaDS.searchDSVisa(textBoxSearch.Text,idManager).Tables[0];
                RowsColor();
            }
        }

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            setTicket();
        }

        private string getSelectNumber()
        {
            selectNumber = new Form_select_number();
            selectNumber.Owner = this;
            selectNumber.ShowDialog();
            return selectNumber.id;
        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            setEmail();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            setClient();
        }

        private Visa getVisaInput(string id)
        {
            return  visaDAO.getVisa(id);
        }

        private void buttonDepType_Click(object sender, EventArgs e)
        {
            setDepType();
        }

        private void buttonPeople_Click(object sender, EventArgs e)
        {
            setPeopleCount();
        }

        private void geckoWebBrowser1_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            label2.Text = "Готово";
            ReloadNav();
            startClick();
            setDepType();
            setTicket();
            setPeopleCount();
            setEmail();
            setClient();
        }
        private void geckoWebBrowser1_NavigationError(object sender, Gecko.Events.GeckoNavigationErrorEventArgs e)
        {
            timer1.Enabled = true;
        }
        private void ReloadNav()
        {
            if (stop != true)
            {
                if (geckoWebBrowser1.Document.GetElementById("aspnetForm") != null)
                    timer1.Enabled = false;
                else
                    timer1.Enabled = true;
            }
        }

        private void startClick()
        {
            try
            {
                GeckoInputElement Loginbutton = new GeckoInputElement(geckoWebBrowser1.Document.GetElementById("ctl00_plhMain_lnkSchApp").DomObject);
                Loginbutton.Click();
            }
            catch (Exception)
            {
                //MessageBox.Show("Возникла ошибка при заполнении полей.");
            }
        }

        private void setDepType()
        {
            try
            {
                visaInput = getVisaInput(dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString());
                var document = geckoWebBrowser1.Document;
                // ctl00_plhMain_cboVAC - select - место визита, город подачи документов
                var place = (GeckoSelectElement)document.GetElementById("ctl00_plhMain_cboVAC");
                place.Value = visaInput.getregion();
                //ctl00_plhMain_cboPurpose - select - цель визита
                var purpose = (GeckoSelectElement)document.GetElementById("ctl00_plhMain_cboPurpose");
                purpose.Value = visaInput.getpurpose();
                //
                GeckoInputElement Loginbutton = new GeckoInputElement(geckoWebBrowser1.Document.GetElementById("ctl00_plhMain_btnSubmit").DomObject);
                Loginbutton.Click();
                GeckoElement links = geckoWebBrowser1.Document.GetElementById("ctl00_plhMain_lblMsg");
                if (links.TextContent.Contains("No date(s) available for appointment"))
                {
                    timer1.Enabled = false;
                    stop = true;
                    label2.Text = "Стоп";
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Возникла ошибка при заполнении полей.");
            }
        }

        private void setTicket()
        {
            // <span id="ctl00_plhMain_lblMsg" class="Validation">квитанція, 6327/0194/7959 is використано</span> ошибка
            try
            {
                var document = geckoWebBrowser1.Document;
                //ctl00_plhMain_repAppReceiptDetails_ctl01_txtReceiptNumber - input - номер квитации

                visaInput = getVisaInput(dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString());
                var purpose = (GeckoInputElement)document.GetElementById("ctl00_plhMain_repAppReceiptDetails_ctl01_txtReceiptNumber");
                purpose.Value = visaInput.getclientticket();



                //ctl00_plhMain_btnSubmit - кнопка сабмита
                GeckoInputElement submitButton = new GeckoInputElement(geckoWebBrowser1.Document.GetElementById("ctl00_plhMain_btnSubmit").DomObject);
                submitButton.Click();

                GeckoElement links = geckoWebBrowser1.Document.GetElementById("ctl00_plhMain_lblMsg");
                if (links.TextContent.Contains("is використано"))
                {
                    timer1.Enabled = false;
                    stop = true;
                    label2.Text = "Стоп";
                    geckoWebBrowser1.Stop();
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Возникла ошибка при заполнении полей.");
            }
        }

        private void setPeopleCount()
        {
            try
            {
                visaInput = getVisaInput(dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString());
                var document = geckoWebBrowser1.Document;

                //ctl00_plhMain_tbxNumOfApplicants - количество взрослых
                var place = (GeckoInputElement)document.GetElementById("ctl00_plhMain_tbxNumOfApplicants");
                place.Value = visaInput.getpersons();
                //ctl00_plhMain_txtChildren - количество детей
                var kids = (GeckoInputElement)document.GetElementById("ctl00_plhMain_txtChildren");
                kids.Value = visaInput.getkids();
                //ctl00_plhMain_cboVisaCategory -категория визы
                GeckoSelectElement type = (GeckoSelectElement)document.GetElementById("ctl00_plhMain_cboVisaCategory");
                type.Value = visaInput.getvisatype();
                
                //geckoWebBrowser1.Navigate("javascript:setTimeout('__doPostBack(\'ctl00$plhMain$cboVisaCategory\',\'\')', 0)");
                //geckoWebBrowser1.Document.GetElementById('ctl00_plhMain_lnkSchApp').InvokeMember("onchange");
                //geckoWebBrowser1.Navigate("__doPostBack(\'ctl00$plhMain$cboVisaCategory\',\'\')', 0));
                //javascript:setTimeout('__doPostBack(\'ctl00$plhMain$cboVisaCategory\',\'\')',  0)
                //type.SetAttribute("onchange","javascript:setTimeout('__doPostBack(\'ctl00$plhMain$cboVisaCategory\',\'\')', 0)");
            }
            catch (Exception)
            {
                //MessageBox.Show("Возникла ошибка при заполнении полей.");
            }
        }

        private void setEmail()
        {
            try
            {
                // дописать цикл для пробега по массиву значений и вставке нужного
                var document = geckoWebBrowser1.Document;
                visaInput = getVisaInput(dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString());

                //ctl00_plhMain_txtEmailID - input - email
                var inputValue = (GeckoInputElement)document.GetElementById("ctl00_plhMain_txtEmailID");
                inputValue.Value = visaInput.getemail();

                //ctl00_plhMain_txtPassword - input - pass
                inputValue = (GeckoInputElement)document.GetElementById("ctl00_plhMain_txtPassword");
                inputValue.Value = visaInput.getpassword();

                //ctl00_plhMain_btnSubmitDetails
                GeckoInputElement submitButton = new GeckoInputElement(geckoWebBrowser1.Document.GetElementById("ctl00_plhMain_btnSubmitDetails").DomObject);
                submitButton.Click();
            }
            catch (Exception)
            {
                //MessageBox.Show("Возникла ошибка при заполнении полей.");
            }
        }

        private void setClient()
        {
            try
            {
                string number = "1";
                // дописать цикл для пробега по массиву значений и вставке нужного
                var document = geckoWebBrowser1.Document;
                visaInput = getVisaInput(dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString());

                //ctl00_plhMain_repAppVisaDetails_ctl01_tbxPPTEXPDT - input - Дата закінчення терміну дії паспорту
                string idValue = "ctl00_plhMain_repAppVisaDetails_ctl0" + number + "_tbxPPTEXPDT";
                var inputValue = (GeckoInputElement)document.GetElementById(idValue);
                inputValue.Value = visaInput.getpassportexpire().Replace('.', '/');
                //w
                //ctl00_plhMain_repAppVisaDetails_ctl01_tbxFName - input - имя
                idValue = "ctl00_plhMain_repAppVisaDetails_ctl0" + number + "_tbxFName";
                inputValue = (GeckoInputElement)document.GetElementById(idValue);
                inputValue.Value = visaInput.getfirstname();
                //w
                //ctl00_plhMain_repAppVisaDetails_ctl01_tbxLName - input- фамилия                  
                idValue = "ctl00_plhMain_repAppVisaDetails_ctl0" + number + "_tbxLName";
                inputValue = (GeckoInputElement)document.GetElementById(idValue);
                inputValue.Value = visaInput.getlastname();

                //ctl00_plhMain_repAppVisaDetails_ctl01_tbxDOB - input - дата рождения
                idValue = "ctl00_plhMain_repAppVisaDetails_ctl0" + number + "_tbxDOB";
                inputValue = (GeckoInputElement)document.GetElementById(idValue);
                inputValue.Value = visaInput.getdob().Replace('.', '/');

                //ctl00_plhMain_repAppVisaDetails_ctl01_tbxReturn - input - дата возврата
                idValue = "ctl00_plhMain_repAppVisaDetails_ctl0" + number + "_tbxReturn";
                inputValue = (GeckoInputElement)document.GetElementById(idValue);
                inputValue.Value = DateTime.Now.AddDays(Convert.ToDouble(visaInput.gettravellength())).ToShortDateString().Replace('.','/');
                /*
                //ctl00_plhMain_repAppVisaDetails_ctl01_tbxContactNumber - input - контактный телефон
                idValue = "ctl00_plhMain_repAppVisaDetails_ctl0" + number + "_tbxContactNumber";
                inputValue = (GeckoInputElement)document.GetElementById(idValue);
                inputValue.Value = "0953317170";
                */
                //ctl00_plhMain_repAppVisaDetails_ctl01_cboNationality - select - национальность
                idValue = "ctl00_plhMain_repAppVisaDetails_ctl0" + number + "_cboNationality";
                var selectValue = (GeckoSelectElement)document.GetElementById(idValue);
                selectValue.Value = visaInput.getnationality();

                //ctl00_plhMain_repAppVisaDetails_ctl01_cboTitle - select - cтатус Mr. etc.
                idValue = "ctl00_plhMain_repAppVisaDetails_ctl0" + number + "_cboTitle";
                selectValue = (GeckoSelectElement)document.GetElementById(idValue);
                selectValue.Value = visaInput.gettitle();
            }
            catch (Exception)
            {
                //MessageBox.Show("Возникла ошибка при заполнении полей.");
            }
        }

        private void selectData()
        {
            //class OpenDateAllocated
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            startClick();
            setDepType();
            setTicket();
            setPeopleCount();
            setEmail();
            setClient();
        }

        private void buttonSelectDate_Click(object sender, EventArgs e)
        {
            string forPars ="";
            GeckoElementCollection links = geckoWebBrowser1.Document.GetElementsByTagName("a");
            bool find = false;
            GeckoHtmlElement clickBut = null;

            foreach (GeckoElement link in links)
            {
                if (!link.GetAttribute("href").Contains("javascript:__doPostBack('ctl00$plhMain$cldAppointment','V"))
                    if (!find)
                    {
                        //textconntent
                        forPars = link.GetAttribute("title");
                        clickBut = (GeckoHtmlElement)link.DomObject;
                        find = true;
                    }
            }
            
            string date ="", month ="";
            if (forPars !="")
            {
                date = clickBut.TextContent;
                //month = forPars.Substring(2, forPars.Length);
                if (Convert.ToInt32(date)<10)
                    date = "0" + date;
            }

            if (Int32.Parse(date) < (DateTime.Now.Day + 14))
            {
                MessageBox.Show(date);
            }
            else
            {
                clickBut.Click();
            }

            month = month.Trim();
            string resultDate="";
            string[] monthString = {"сiч", "лют","бер","кві","тра","чер",
                                    "лип","сер","вер","жов","лис","гру"};
            for (int i = 0; i < monthString.Length;i++)
            {
                if (month.Contains(monthString[i]))
                {
                    string monthplus="";
                    if (i < 9)
                        monthplus = "0";

                    MessageBox.Show(date + "." + monthplus + (i + 1).ToString() + "." + DateTime.Now.Year);
                    resultDate = date + "." + monthplus + (i + 1).ToString() + "." + DateTime.Now.Year;
                }
            }

            //visaDAO.saveDate(resultDate, dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString());
        }

        public void RowsColor()
        {
            for(int i = 0; i <dataGridViewVisa.Rows.Count; i++)
            {
                int value = Int32.Parse(dataGridViewVisa.Rows[i].Cells[2].Value.ToString());
                if (value ==0)
                {
                    dataGridViewVisa.Rows[i].DefaultCellStyle.BackColor = Color.Silver;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool pickTime = false;
            int i = 1;
            do
            {
                try
                {
                    Gecko.GeckoHtmlElement Btn = (Gecko.GeckoHtmlElement)geckoWebBrowser1.DomDocument.GetElementById("ctl00_plhMain_gvSlot_ctl0" + i + "_lnkTimeSlot");
                    Btn.Click();
                    pickTime = true;
                }
                catch(Exception)
                {

                }
                i = i + 1;

            } 
            while (!pickTime);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PasswordMD5 md5 = new PasswordMD5();
            MessageBox.Show(md5.MD5("test1"));
        }
    }
}
  