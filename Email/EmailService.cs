using Simple.EmailServer;
using System;
using System.Net.Mail;

namespace Simple.Service
{
    public class EmailService
    {
        public string DetailedEmail(string recipient, string sender, string message, string recipient_name, string subject)
        {
            var verdict = "";
            try
            {
                var mail = new Email();
                mail.recipient = recipient;
                mail.prioritylevel = MailPriority.Low;
                mail.subject = subject;
                var body = $"<h1>Detailed Email</h1></br></br>Dear : {recipient_name} </br></br><p>{message}</p></br></br>Sincerely</br>{sender}";
                mail.body = body;
                mail.SendEmail();
                verdict = "email sent..."; 
            }
            catch (Exception ex)
            {
                verdict = $"email failed error {ex.HResult} \n with message : {ex.Message}";
            }

            return verdict;

        }

        public string BasicEmail(string recipient, string sender, string message, string recipient_name)
        {
            var verdict = "";

            try
            {
                var mail = new Email();
                mail.recipient = recipient;
                mail.prioritylevel = MailPriority.Normal;
                mail.subject = "basic email";
                var body = $"<h1>Basic Email</h1></br></br>Dear : {recipient_name} </br></br><p>{message}</p></br></br>Thank you.";
                mail.body = body;
                mail.SendEmail();
                verdict = "email sent...";
            }catch (Exception ex)
            {
                verdict = $"email failed error {ex.HResult} \n with message : {ex.Message}";
            }

            return verdict;
}
    }
}