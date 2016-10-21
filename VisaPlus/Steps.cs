using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko;
using Gecko.DOM;
using System.Windows.Forms;
using System.Threading;

namespace VisaPlus
{
    class Steps
    {
        private Thread myThread = new Thread(func); 
        //private Visa visaInput = new Visa();
        private VisaDAO visaDAO = new VisaDAOImp();
        static void func()//Функция потока, передаем параметр
        {
            Thread.Sleep(100);
            SendKeys.SendWait("{ENTER}");
        }

        private Visa getVisaInput(string id)
        {
            return visaDAO.getVisa(id);
        }

        public void ReloadNav(object sender)
        {
            var webGecko = sender as GeckoWebBrowser;
            if (webGecko.Document.GetElementById("aspnetForm") == null || webGecko.Document.GetElementById("__VIEWSTATE") == null)
            {
                myThread.Start(); //запускаем поток
                webGecko.Reload();
            }
        }


        public void startClick(object sender)
        {
            var webGecko = sender as GeckoWebBrowser;
            try
            {
                GeckoInputElement Loginbutton = new GeckoInputElement(webGecko.Document.GetElementById("ctl00_plhMain_lnkSchApp").DomObject);
                Loginbutton.Click();
            }
            catch (Exception)
            {
                //MessageBox.Show("Возникла ошибка при заполнении полей.");
            }
        }

        public void setDepType(object sender, List<Visa> visas)
        {
            var webGecko = sender as GeckoWebBrowser;
            try
            {
                GeckoElement links = webGecko.Document.GetElementById("ctl00_plhMain_lblMsg");

                if (!links.TextContent.Contains("No date(s) available for appointment"))
                {
                    //visaInput = getVisaInput(dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString());
                    var document = webGecko.Document;
                    // ctl00_plhMain_cboVAC - select - место визита, город подачи документов
                    var place = (GeckoSelectElement)document.GetElementById("ctl00_plhMain_cboVAC");
                    place.Value = visas[0].getregion();
                    //ctl00_plhMain_cboPurpose - select - цель визита
                    var purpose = (GeckoSelectElement)document.GetElementById("ctl00_plhMain_cboPurpose");
                    purpose.Value = visas[0].getpurpose();
                    //
                    GeckoInputElement Loginbutton = new GeckoInputElement(webGecko.Document.GetElementById("ctl00_plhMain_btnSubmit").DomObject);
                    Loginbutton.Click();

                    //timer1.Enabled = false;
                    //stop = true;
                    //label2.Text = "Стоп";
                }
                else
                {
                    
                    //webGecko.Navigate(webGecko.Url.AbsoluteUri);
                    //Создаем новый объект потока (Thread)

                    myThread.Start(); //запускаем поток
                    webGecko.Reload();
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Возникла ошибка при заполнении полей.");
            }
        }

        public void setTicket(object sender, List<Visa> visas)
        {
            var webGecko = sender as GeckoWebBrowser;
            // <span id="ctl00_plhMain_lblMsg" class="Validation">квитанція, 6327/0194/7959 is використано</span> ошибка
            try
            {
                GeckoElement links = webGecko.Document.GetElementById("ctl00_plhMain_lblMsg");
                if (!links.TextContent.Contains("is використано"))
                {
                    var document = webGecko.Document;
                    //ctl00_plhMain_repAppReceiptDetails_ctl01_txtReceiptNumber - input - номер квитации
                    for (int i = 0; i < visas.Count; i++)
                    {
                        //visaInput = getVisaInput(dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString());
                        var purpose = (GeckoInputElement)document.GetElementById("ctl00_plhMain_repAppReceiptDetails_ctl01_txtReceiptNumber");
                        purpose.Value = visas[i].getclientticket();
                    }

                    //ctl00_plhMain_btnSubmit - кнопка сабмита
                    GeckoInputElement submitButton = new GeckoInputElement(webGecko.Document.GetElementById("ctl00_plhMain_btnSubmit").DomObject);
                    submitButton.Click();
                }
                else
                {
                    //timer1.Enabled = false;
                    //stop = true;
                    //label2.Text = "Готово";
                    webGecko.Stop();
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Возникла ошибка при заполнении полей.");
            }
        }

        public void setPeopleCount(object sender, List<Visa> visas)
        {
            var webGecko = sender as GeckoWebBrowser;
            try
            {
                //visaInput = getVisaInput(dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString());
                var document = webGecko.Document;

                //ctl00_plhMain_tbxNumOfApplicants - количество взрослых
                var place = (GeckoInputElement)document.GetElementById("ctl00_plhMain_tbxNumOfApplicants");
                place.Value = visas.Count.ToString();
                //ctl00_plhMain_txtChildren - количество детей
                int kidsCount = 0;
                for (int i = 0; i < visas.Count; i++)
                {
                    kidsCount = kidsCount + Int32.Parse(visas[i].getkids());
                }
                var kids = (GeckoInputElement)document.GetElementById("ctl00_plhMain_txtChildren");
                // дописать вытягивание детей
                kids.Value = kidsCount.ToString();
                //ctl00_plhMain_cboVisaCategory - категория визы
                GeckoSelectElement type = (GeckoSelectElement)document.GetElementById("ctl00_plhMain_cboVisaCategory");
                type.Value = visas[0].getvisatype();

                //webGecko.Refresh();
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

        public void setEmail(object sender, List<Visa> visas)
        {
            var webGecko = sender as GeckoWebBrowser;
            try
            {
                // дописать цикл для пробега по массиву значений и вставке нужного
                var document = webGecko.Document;
                //visaInput = getVisaInput(dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString());

                //ctl00_plhMain_txtEmailID - input - email
                var inputValue = (GeckoInputElement)document.GetElementById("ctl00_plhMain_txtEmailID");
                inputValue.Value = visas[0].getemail();

                //ctl00_plhMain_txtPassword - input - pass
                inputValue = (GeckoInputElement)document.GetElementById("ctl00_plhMain_txtPassword");
                inputValue.Value = visas[0].getpassword();

                //ctl00_plhMain_btnSubmitDetails
                GeckoInputElement submitButton = new GeckoInputElement(webGecko.Document.GetElementById("ctl00_plhMain_btnSubmitDetails").DomObject);
                submitButton.Click();
            }
            catch (Exception)
            {
                //MessageBox.Show("Возникла ошибка при заполнении полей.");
            }
        }

        public void setClient(object sender, List<Visa> visas)
        {

            var webGecko = sender as GeckoWebBrowser;
            try
            {
                string number = "1";
                // дописать цикл для пробега по массиву значений и вставке нужного
                var document = webGecko.Document;
                //visaInput = getVisaInput(dataGridViewVisa[0, dataGridViewVisa.CurrentCell.RowIndex].Value.ToString());
                for (int i = 0; i < visas.Count; i++)
                {
                    //ctl00_plhMain_repAppVisaDetails_ctl01_tbxPPTEXPDT - input - Дата закінчення терміну дії паспорту
                    string idValue = "ctl00_plhMain_repAppVisaDetails_ctl0" + number + "_tbxPPTEXPDT";
                    var inputValue = (GeckoInputElement)document.GetElementById(idValue);
                    inputValue.Value = visas[i].getpassportexpire().Replace('.', '/');
                    //w
                    //ctl00_plhMain_repAppVisaDetails_ctl01_tbxFName - input - имя
                    idValue = "ctl00_plhMain_repAppVisaDetails_ctl0" + number + "_tbxFName";
                    inputValue = (GeckoInputElement)document.GetElementById(idValue);
                    inputValue.Value = visas[i].getfirstname();
                    //w
                    //ctl00_plhMain_repAppVisaDetails_ctl01_tbxLName - input- фамилия                  
                    idValue = "ctl00_plhMain_repAppVisaDetails_ctl0" + number + "_tbxLName";
                    inputValue = (GeckoInputElement)document.GetElementById(idValue);
                    inputValue.Value = visas[i].getlastname();

                    //ctl00_plhMain_repAppVisaDetails_ctl01_tbxDOB - input - дата рождения
                    idValue = "ctl00_plhMain_repAppVisaDetails_ctl0" + number + "_tbxDOB";
                    inputValue = (GeckoInputElement)document.GetElementById(idValue);
                    inputValue.Value = visas[i].getdob().Replace('.', '/');

                    //ctl00_plhMain_repAppVisaDetails_ctl01_tbxReturn - input - дата возврата
                    idValue = "ctl00_plhMain_repAppVisaDetails_ctl0" + number + "_tbxReturn";
                    inputValue = (GeckoInputElement)document.GetElementById(idValue);
                    inputValue.Value = DateTime.Now.AddDays(Convert.ToDouble(visas[i].gettravellength())).ToShortDateString().Replace('.', '/');
                    /*
                    //ctl00_plhMain_repAppVisaDetails_ctl01_tbxContactNumber - input - контактный телефон
                    idValue = "ctl00_plhMain_repAppVisaDetails_ctl0" + number + "_tbxContactNumber";
                    inputValue = (GeckoInputElement)document.GetElementById(idValue);
                    inputValue.Value = "0953317170";
                    */
                    //ctl00_plhMain_repAppVisaDetails_ctl01_cboNationality - select - национальность
                    idValue = "ctl00_plhMain_repAppVisaDetails_ctl0" + number + "_cboNationality";
                    var selectValue = (GeckoSelectElement)document.GetElementById(idValue);
                    selectValue.Value = visas[i].getnationality();

                    //ctl00_plhMain_repAppVisaDetails_ctl01_cboTitle - select - cтатус Mr. etc.
                    idValue = "ctl00_plhMain_repAppVisaDetails_ctl0" + number + "_cboTitle";
                    selectValue = (GeckoSelectElement)document.GetElementById(idValue);
                    selectValue.Value = visas[i].gettitle();
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Возникла ошибка при заполнении полей.");
            }
        }

        public void selectTime(object sender)
        {
            try
            {
                var webGecko = sender as GeckoWebBrowser;

                Gecko.GeckoHtmlElement Btn = (Gecko.GeckoHtmlElement)webGecko.DomDocument.GetElementById("ctl00_plhMain_gvSlot_ctl02_lnkTimeSlot");
                Btn.Click();

            }
            catch (Exception)
            {
                //MessageBox.Show("Возникла ошибка при заполнении полей.");
            }
        }

        public void selectDate(object sender, List<Visa> visas)
        {
            try
            {
                var webGecko = sender as GeckoWebBrowser;
                string forPars = "";
                GeckoElementCollection links = webGecko.Document.GetElementsByTagName("a");
                bool find = false;
                GeckoHtmlElement clickBut = null;

                GeckoElement check = webGecko.Document.GetElementById("ctl00_plhMain_lblappdate");
    

               
                //ctl00_plhMain_lblappdate Призначення дати подачі документів
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
                if (check.TextContent.Contains("Призначення дати подачі документів"))
                {
                    if (find)
                    {
                        string date = "", month = "";
                        if (forPars != "")
                        {
                            date = clickBut.TextContent;
                            if (Convert.ToInt32(date) < 10)
                                date = "0" + date;
                        }

                        // переделать парсинг, парсить месяц и умножать на 30 каждый месяц

                        //MessageBox.Show(date);
                        month = month.Trim();
                        string resultDate = "";
                        string[] monthString = {"сiч", "лют","бер","кві","тра","чер",
                                    "лип","сер","вер","жов","лис","гру"};
                        for (int i = 0; i < monthString.Length; i++)
                        {
                            if (month.Contains(monthString[i]))
                            {
                                string monthplus = "";
                                if (i < 9)
                                    monthplus = "0";
                                int monthCalc = i;
                                if ((monthCalc - DateTime.Now.Month) < 0)
                                    monthCalc = monthCalc + 12;
                                int monthDay = (monthCalc -  DateTime.Now.Month) * 30 + Int32.Parse(date);
                                if (monthDay <= 14)
                                {
                                    //MessageBox.Show(date + "." + monthplus + (i + 1).ToString() + "." + DateTime.Now.Year);
                                    resultDate = date + "." + monthplus + (i + 1).ToString() + "." + DateTime.Now.Year;
                                    clickBut.Click();
                                    for (int j = 0; j < visas.Count; j++)
                                    {
                                        visaDAO.saveDate(resultDate, visas[j].getId());
                                    }
                                }
                            }
                        }

                    }
                    else
                    {
                        myThread.Start(); //запускаем поток
                        webGecko.Reload();
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Возникла ошибка при заполнении полей.");
            }
        }

        public void setStatus(object sender, List<Visa> visas)
        {
            try
            {
                var webGecko = sender as GeckoWebBrowser;
                if (webGecko.Document.GetElementById("ApplicantDetalils") != null)
                {
                    for (int i = 0; i < visas.Count; i++)
                    {
                        visaDAO.saveStatus(visas[i].getId());
                    }
                }

            }
            catch (Exception)
            {
                //MessageBox.Show("Возникла ошибка при заполнении полей.");
            }
        }
    }
}
