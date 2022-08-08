using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaFide.Domain.Models
{
    public class Roles
    {
        [Key]
        public int IdRol { get; set; }

        [Required]
        [MaxLength(250)]
        public string Description { get; set; }
        [Required]
        [MaxLength(250)]
        public string Puesto { get; set; }
        [Required]
        public double Salario { get; set; }
        

    }
}
