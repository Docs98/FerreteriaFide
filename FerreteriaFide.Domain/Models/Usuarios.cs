using IdentityModel;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaFide.Domain.Models
{
    public class Usuarios
    {
        [Key]
        public int Cedula { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        public string Clave { get; set; }
        [Required]
        public string Email { get; set; }
        public int Telefono { get; set; }

        public virtual Roles roles { get; set; }

    }
}
