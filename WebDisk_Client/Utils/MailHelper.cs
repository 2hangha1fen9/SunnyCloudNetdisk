using System;
using System.Net;
using System.Net.Mail;
using WebDisk_Client.Properties;

namespace WebDisk_Client.Utils
{
    static class MailHelper
    {
        public static void SendMail(string reciver, string subject, string content)
        {
            try
            {
                MailMessage message = new MailMessage(Settings.Default.mailAccount, reciver, subject, content);
                message.IsBodyHtml = true;
                SmtpClient client = new SmtpClient(Settings.Default.mailServer, Settings.Default.mailPort);
                client.Credentials = new NetworkCredential(Settings.Default.mailAccount, Settings.Default.mailPassword);
                client.EnableSsl = true;
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception("发送失败");
            }
        }
    }
}
