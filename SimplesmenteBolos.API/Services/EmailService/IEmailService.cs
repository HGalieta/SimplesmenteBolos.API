using SimplesmenteBolos.API.Models;

namespace SimplesmenteBolos.API.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(Pedido pedido) {}
    }
}
