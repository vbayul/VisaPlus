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
        private readonly Dictionary<GeckoWebBrowser, TabPage> _wbPages;
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
        private List<Visa> visaStore= new List<Visa>();
        private Steps steps = new Steps();
        public Form_visa()
        {
            InitializeComponent();
            this._wbPages = new Dictionary<GeckoWebBrowser, TabPage>();
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

            // запрет кеширования страницы.
            Gecko.GeckoPreferences.User["browser.cache.disk.enable"] = false;
            Gecko.GeckoPreferences.User["browser.cache.memory.enable"] = false;
            Param.setConnectionString("database=" + Properties.Settings.Default.DB + ";server=" + Properties.Settings.Default.DBURL + ";uid=qbdp_u_pol;password=%eV4gzTdtL*6");
            
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
            RowsColor();
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
                    RowsColor();
                }
                else
                {
                    dataGridViewVisa.DataSource = visaDS.searchDSVisa(textBoxSearch.Text, idManager).Tables[0];
                    RowsColor();
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
                Gecko.GeckoPreferences.User["network.proxy.type"] = 0;
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
            //stop = true;
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
            //setTicket();
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
            //setEmail();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            //setClient();
        }

        private void buttonDepType_Click(object sender, EventArgs e)
        {
            //setDepType();
        }

        private void buttonPeople_Click(object sender, EventArgs e)
        {
            //setPeopleCount();
        }

        private void geckoWebBrowser1_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            timer1.Enabled = false;
            label2.Text = "Готово";
            /*
            ReloadNav();
            //startClick();
            setDepType();
            setTicket();
            setPeopleCount();
            setEmail();
            setClient();*/
        }
        private void geckoWebBrowser1_NavigationError(object sender, Gecko.Events.GeckoNavigationErrorEventArgs e)
        {
            timer1.Enabled = true;
        }




        private void buttonSelectDate_Click(object sender, EventArgs e)
        {


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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewVisa.RowCount > 0)
            {
                proxy = proxyDAO.getProxy();
                //label2.Text = "Загрузка";
                if (proxy.getProxyIP() != null)
                {
                    label1.Text = "Прокси - http://" + proxy.getProxyIP() + ":" + proxy.getProxyPort();
                    Gecko.GeckoPreferences.User["network.proxy.type"] = 1;
                    Gecko.GeckoPreferences.User["network.proxy.http"] = proxy.getProxyIP();
                    Gecko.GeckoPreferences.User["network.proxy.http_port"] = Convert.ToInt32(proxy.getProxyPort());
                    Gecko.GeckoPreferences.User["network.proxy.ssl"] = proxy.getProxyIP();
                    Gecko.GeckoPreferences.User["network.proxy.ssl_port"] = Convert.ToInt32(proxy.getProxyPort());
                    //geckoWebBrowser1.Navigate(@"2ip.ru");
                }
                else
                {
                    label1.Text = "Прокси - нет";
                    Gecko.GeckoPreferences.User["network.proxy.type"] = 0;
                    //geckoWebBrowser1.Navigate(@"2ip.ru");
                }

                AddTab();
            }
        }


        private Visa getVisaInput(string id)
        {
            return visaDAO.getVisa(id);
        }

        private void AddTab()
        {
            Visa visacur = getVisaInput(dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString());
            visaStore.Add(visacur); 
            TabPage tabPage = new TabPage("Поиск даты");

            var webBrowser = new GeckoWebBrowser { Dock = DockStyle.Fill };
            var progressBar = new ProgressBar();
            //webBrowser.Text = dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString(); на случай если нужно дергать базу
            webBrowser.Text = (visaStore.Count-1).ToString();
            // обработчик события изменения заголовка
            //webBrowser.DocumentTitleChanged += this.webBrowser_DocumentTitleChanged;
            // обработчик создания окна
            //webBrowser.CreateWindow2 += this.webBrowser_CreateWindow2;
            // обработчик события завершения загрузки
            webBrowser.DocumentCompleted += this.webBrowser_DocumentCompleted;
            webBrowser.ProgressChanged += this.webBrowser_ProgressChanged;
            // добавляем контрол браузера на новую вкладку
            tabPage.Controls.Add(webBrowser);
            //tabPage.Controls.Add(progressBar);
            // добавляет новую вкладку
            this.tabControlGecko.TabPages.Add(tabPage);
            // делаем активной новую вкладку
            this.tabControlGecko.SelectedTab = tabPage;
            // добавляем в словарь ссылку на браузер и вкладку
            this._wbPages.Add(webBrowser,tabPage);
            // загружаем страницу
            webBrowser.Navigate(URL);
        }

        private GeckoWebBrowser GetWebBrowserByActiveTab()
        {
            // получаем активную вкладку
            TabPage selectedTab = this.tabControlGecko.SelectedTab;
            // ищем первый элемент в словаре, значения которого (т.е. ссылка на вкладку) равна активной вкладке
            // данный метод возвратит либо ссылку на браузер, либо null
            return this._wbPages.FirstOrDefault(t => t.Value == selectedTab).Key;
        }

        private void webBrowser_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            var webGecko = sender as GeckoWebBrowser;
            Visa visa = visaStore[Convert.ToInt32(webGecko.Text)];
            //var tab = Parent.Text as TabPage;
            //MessageBox.Show(this.Parent.Text);
            //tabControlGecko.TabPages.Name.ToString();
            //steps.ReloadNav(sender);
            steps.startClick(sender);
            steps.setDepType(sender, visa);
            steps.setTicket(sender, visa);
            steps.setPeopleCount(sender, visa);
            steps.setEmail(sender, visa);
            steps.setClient(sender, visa);
            steps.selectDate(sender, visa);
            steps.selectTime(sender);
            //MessageBox.Show(tabControlGecko.TabCount.ToString());
        }

        private void webBrowser_ProgressChanged(object sender, Gecko.GeckoProgressEventArgs e)
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

        private void buttonTabClose_Click(object sender, EventArgs e)
        {
            this.CloseActiveTab();
        }
        private void CloseActiveTab()
        {
            // получаем активную вкладку
            TabPage selectedTab = this.tabControlGecko.SelectedTab;
            if (selectedTab == null)
            {
                return;
            }
            // получаем ссылку на браузер
            GeckoWebBrowser webBrowser = this.GetWebBrowserByActiveTab();
            // удаляем со словаря
            this._wbPages.Remove(webBrowser);
            // уничтожаем браузер
            webBrowser.Dispose();
            webBrowser = null;
            // удаляем вкладку
            this.tabControlGecko.TabPages.Remove(this.tabControlGecko.SelectedTab);
            // принудительно запускаем сборщик мусора
            GC.Collect();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
  