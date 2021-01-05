using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Net.Mail;

namespace EmailSenderUI
{
    class MailSender
    {
        public static void Send(string to, string subject, string body, string password)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

                mailMessage.From = new MailAddress("literallyallothernamesaretaken@gmail.com", "Custom name");
                mailMessage.To.Add(to);
                mailMessage.Subject = subject;
                mailMessage.Body = body;

                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential("literallyallothernamesaretaken@gmail.com", password);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mailMessage);
                MessageBox.Show("Mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
