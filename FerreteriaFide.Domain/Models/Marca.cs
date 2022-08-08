using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaFide.Domain.Models
{
    public class Marca
    {
        [Key]
        [Required]
        public int IdMarca { get; set; }
        [MaxLength(55)]
        [Required]
        public string Nombre { get; set; }
        

    }
}
