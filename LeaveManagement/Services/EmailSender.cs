using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagement.Services
{
    public class EmailSender :IEmailSender
    {
        public string SmtpHost { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUsername { get; set; }
        public EmailSender(string smtpHost, int smtpPort, string smtpUsername)
        {
            SmtpHost = smtpHost;
            SmtpPort = smtpPort;
            SmtpUsername = smtpUsername;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var Message = new MailMessage()
            {
                From = new MailAddress(this.SmtpUsername),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };
            Message.To.Add(new MailAddress(email));

            using var client = new SmtpClient(SmtpHost, SmtpPort);
            client.Send(Message);
            return Task.CompletedTask;

        }
    }
}
