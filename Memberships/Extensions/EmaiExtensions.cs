using Microsoft.AspNet.Identity;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace Memberships.Extensions
{
    public static class EmailExtensions
    {
        public static void Send(this IdentityMessage message)
        {
            try
            {
         
                var password = ConfigurationManager.AppSettings["password"];
                var from = ConfigurationManager.AppSettings["from"];
                var host = ConfigurationManager.AppSettings["host"];
                var port = int.Parse(ConfigurationManager.AppSettings["port"]);

              
                var email = new MailMessage(
                    from, message.Destination, message.Subject, message.Body);
                email.IsBodyHtml = true;

                var client = new SmtpClient(host, port);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from, password);

                client.Send(email);
            }
            catch { }

        }
    }
}