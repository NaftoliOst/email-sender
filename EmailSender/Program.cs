using System;
using System.Net.Mail;

namespace EmailSender
{

    class Program
    {
        public static bool IsValidEmail(string address)
        {
            try
            {
                var ad = new System.Net.Mail.MailAddress(address);
                return ad.Address == address;
            }
            catch 
            {

                return false;
            }
            
        }
        public static void SendMail(string to, string sub, string txt, string pswd)
        {
            
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("literallyallothernamesaretaken@gmail.com", "Custom name");
                mail.To.Add(to);
                mail.ReplyToList.Add(new MailAddress("Noreply@myapp.com"));
                mail.Subject = sub;
                mail.IsBodyHtml = true;
                mail.Body = txt;
               // string state = mail.DeliveryNotificationOptions;


                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("literallyallothernamesaretaken@gmail.com", pswd);
                smtp.EnableSsl = true;

                smtp.Send(mail);
                Console.WriteLine("Message sent");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        static void Main(string[] args)
        {
            
            string rec;
            do
            {
                Console.WriteLine("Enter the recipient email address");
                rec = Console.ReadLine();
            } while (!IsValidEmail(rec));
            
            Console.WriteLine();
            Console.WriteLine("Enter the subject");
            String sbj = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter body text");
            string bdy = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter password to email account");
            string password = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter 'send' to send email");
            // Console.WriteLine("Enter 'send' or 'sendhtml' to send email");
 
            while (true)
            {
                string snd = Console.ReadLine();
                Console.WriteLine();
                //if (snd == "sendhtml")
                //{
                //    SendMail(snd, sbj, bdy, true);
                //}
                if (snd == "send")
                {
                    SendMail(rec, sbj, bdy, password);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("press any key to exit");
                    break;
                }
                else if (snd == "exit")
                {
                    break;
                }   
                else
                {
                    Console.WriteLine("Enter 'send' to send email or 'exit' to abort");
                    Console.WriteLine();
                }
            }
            
            
        }
    }
}
