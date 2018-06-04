using System.Net;
using System.Net.Mail;

namespace Simple.EmailServer
{
    public class Email
    {
        public string recipient { get; set; }            // email recipient
        public string body { get; set; }                 // email body
        public string subject { get; set; }              // email subject header
        public MailPriority prioritylevel { get; set; }  // email priority level

        public void SendEmail()
        {
            MailMessage mail = new MailMessage();
            mail.From = new System.Net.Mail.MailAddress("email@address.com");
            
            //smtp configuration
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("adress@gmail.com", "paSsword$123");  // email address and password
            smtp.Host = "smtp.gmail.com"; //any other smtp host will suffice

            //recipient address
            mail.To.Add(new MailAddress(recipient));

            //Formatted mail body
            mail.IsBodyHtml = true;

            mail.Body = body;
            mail.Subject = subject;

            mail.Priority = prioritylevel;

            smtp.Send(mail);
        }
    }
}