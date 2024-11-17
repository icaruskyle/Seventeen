using MailKit.Net.Smtp;
using MimeKit;
using System;

namespace new_email_tool
{
    public class EmailService
    {
        string _smtpServer = "sandbox.smtp.mailtrap.io";
        int _port = 2525;
        string _userName = "fff467d51f5c6f";
        string _password = "1d446921bf8d05";
        string _recipientName = "Aldrin Kyle Almenanza";
        string _recipientEmail = "aaldrinkyle@gmail.com";
        public void SendEmail(string subject, string htmlBody)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Hello Say The Name Seventeen", "saythename@gmail.com"));
            message.To.Add(new MailboxAddress(_recipientName, _recipientEmail));
            message.Subject = subject;

            message.Body = new TextPart("html")
            {
                Text = htmlBody
            };

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect(_smtpServer, _port, MailKit.Security.SecureSocketOptions.StartTls);
                    client.Authenticate(_userName, _password);
                    client.Send(message);
                    Console.WriteLine("Email sent successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error sending email: {ex.Message}");
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
        }
    }
}
