using System.Net.Mail;
using System.Threading.Tasks;

namespace Tutorials.UmbracoDI.Core.Services
{
    public class CommunicationService : ICommunicationService
    {
        public async Task SendCommentToHost(string name, string email, string comment)
        {
            var message = new MailMessage();
            message.To.Add(new MailAddress("info@umbrace.be"));  // replace with valid value 
            message.From = new MailAddress(email);  // replace with valid value
            message.Subject = name + " send you a message";
            message.Body = comment;
            message.IsBodyHtml = false;

            using (var smtp = new SmtpClient())
            {
                await smtp.SendMailAsync(message);
            }
        }
    }
}
