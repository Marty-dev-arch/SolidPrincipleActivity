using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace SolidPrincipleActivity
{
    public interface IEmailService
    {
        void SendInvoice(string recipientEmail, decimal total);
    }

    public interface IPrinterService
    {
        void PrintInvoice(string recipientEmail, decimal total);
    }

    public class SmtpEmailService : IEmailService
    {
        private readonly string _smtpHost;
        private readonly string _gmailAccount;
        private readonly string _appPassword;

        public SmtpEmailService(
            string smtpHost = "smtp.gmail.com",
            string gmailAccount = "l.goboy.145625.tc@umindanao.edu.ph.test-google-a.com",
            string appPassword = "xlkf nriw qyla pxgn")
        {
            _smtpHost = smtpHost;
            _gmailAccount = gmailAccount;
            _appPassword = appPassword;
        }

        public void SendInvoice(string recipientEmail, decimal total)
        {
            if (!MailAddress.TryCreate(recipientEmail?.Trim(), out var recipient))
            {
                throw new ArgumentException("Enter a valid recipient email address.", nameof(recipientEmail));
            }

            if (!MailAddress.TryCreate(_gmailAccount?.Trim(), out var sender))
            {
                throw new InvalidOperationException("The configured sender email address is invalid.");
            }

            using var smtp = new SmtpClient(_smtpHost)
            {
                Port = 465,
                EnableSsl = true,
                Credentials = new NetworkCredential(_gmailAccount, _appPassword)
            };

            using var mail = new MailMessage(sender, recipient)
            {
                Subject = "Invoice",
                Body = $"Your total is {total:C}"
            };

            smtp.Send(mail);
        }
    }
}
