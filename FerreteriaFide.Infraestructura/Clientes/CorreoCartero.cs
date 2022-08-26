using FerreteriaFide.Aplicacion.Contratos;
using FerreteriaFide.Domain.Models;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

namespace FerreteriaFide.Infraestructura.Clientes
{
    public class CorreoCartero : ICartero

    {
        ConfiguracionSmtp ConfiguracionSmtp;
        public CorreoCartero(IOptions<ConfiguracionSmtp> configuracion)
        {
            this.ConfiguracionSmtp = configuracion.Value;
        }

        public void Enviar(CorreoElectronico correo)
        {
            var clienteSmpt =
                 new SmtpClient
                 {
                     Host = this.ConfiguracionSmtp.Servidor,
                     Port = this.ConfiguracionSmtp.Puerto,
                     EnableSsl = true,
                     UseDefaultCredentials = false,
                     DeliveryMethod = SmtpDeliveryMethod.Network,
                     Credentials =
                         new NetworkCredential
                         {
                             UserName = ConfiguracionSmtp.Usuario,
                             Password = ConfiguracionSmtp.Contrasena
                         }
                 };
            MailMessage mensaje = 
                new MailMessage 
                {
                    From= new MailAddress(this.ConfiguracionSmtp.Remitente),
                    Subject=correo.Asunto,
                    Body=correo.Cuerpo
                };
            mensaje.To.Add(new MailAddress(correo.Destinatario));
            clienteSmpt.Send(mensaje);


        }
    }
}
