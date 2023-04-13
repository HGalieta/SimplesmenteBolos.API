using MailKit.Security;
using MimeKit.Text;
using MimeKit;
using MailKit.Net.Smtp;
using SimplesmenteBolos.API.Models;

namespace SimplesmenteBolos.API.Services.EmailService
{
    public class EmailService : IEmailService
    {
        public void SendEmail(Pedido pedido)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("gilbert.reynolds@ethereal.email"));
            email.To.Add(MailboxAddress.Parse(pedido.Cliente.Email));
            email.Subject = "Simplesmente Bolos - Confirmação de pedido";
            email.Body = new TextPart(TextFormat.Plain) {
                Text = pedido.ToMail(pedido) 
            };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("gilbert.reynolds@ethereal.email", "3tDWyYJCWN3hGpUknv");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
