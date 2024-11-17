using MailKit.Net.Smtp;
using MimeKit;


namespace new_email_tool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Say the Name Seventeen!!", "saythename@gmail.com"));
            message.To.Add(new MailboxAddress("User", "aaldrinkyle@gmail.com"));
            message.Subject = "Thanks for Subscribing!";

            message.Body = new TextPart("html")
            {
                Text = "<h1>Hi, User!</h1>" +
                "<p>Thank you for subscribing to Carat Membership</p>" +
                "<p><strong>Welcome!</strong></p>"
            };

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect("sandbox.smtp.mailtrap.io", 2525, MailKit.Security.SecureSocketOptions.StartTls);

                    client.Authenticate("fff467d51f5c6f", "1d446921bf8d05");

                    client.Send(message);
                    Console.WriteLine("Email sent successfully through Mailtrap.");
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