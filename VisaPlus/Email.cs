using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace VisaPlus
{
    class Email
    {
        SystemSetting systemSetting = new SystemSetting();
        /// <summary>
        /// Отправка письма на почтовый ящик C# mail send
        /// </summary>
        /// <param name="smtpServer">Имя SMTP-сервера</param>
        /// <param name="from">Адрес отправителя</param>
        /// <param name="password">пароль к почтовому ящику отправителя</param>
        /// <param name="mailto">Адрес получателя</param>
        /// <param name="caption">Тема письма</param>
        /// <param name="message">Сообщение</param>
        /// <param name="attachFile">Присоединенный файл</param>
        public void SendMail(string mailto, string caption, string message)
        {

            try
            {
                string from = systemSetting.getValue("email");
                string smtp = systemSetting.getValue("smtp");
                int port = Convert.ToInt32(systemSetting.getValue("port"));
                string password = systemSetting.getValue("password");
                bool ssl = Convert.ToBoolean(Int32.Parse(systemSetting.getValue("ssl")));

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = caption;
                mail.Body = message;
                SmtpClient client = new SmtpClient();
                client.Host = smtp;
                client.Port = port;
                client.EnableSsl = ssl;
                client.Credentials = new NetworkCredential(from.Split('@')[0], password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
