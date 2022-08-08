using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaFide.Domain.Models
{
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(255)]
        public string Direccion { get; set; }
        [Required]
        [MaxLength(255)]
        public string Correo { get; set; }
        [Required]
        public int Telefono { get; set; }
    }
}
