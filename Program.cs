using Simple.Service;
using System;


namespace Email_Abp.Mailkit
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new EmailService();
            var verdict = email.BasicEmail("address@gmail.com", "Individual", "It works ;-) </br> now tell people about my page", "reciever");

            // If its the first time using your email address as a sender
            // It will require you to verify or enable anonymus acces the first time you add it

            Console.WriteLine(verdict);
            Console.ReadKey();
        }
    }
}
