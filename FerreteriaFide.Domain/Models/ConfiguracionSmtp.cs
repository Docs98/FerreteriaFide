namespace FerreteriaFide.Domain.Models
{
    public class ConfiguracionSmtp
    {
        public const string config = "ConfiguracionSmtpOutlook";
        public string Remitente { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Servidor { get; set; }
        public int Puerto { get; set; }


    }
}
