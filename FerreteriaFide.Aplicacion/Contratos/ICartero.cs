using FerreteriaFide.Domain.Models;

namespace FerreteriaFide.Aplicacion.Contratos
{
    public interface ICartero
    {
        void Enviar(CorreoElectronico correo);
    }
}
