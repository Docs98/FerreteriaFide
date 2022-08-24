using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaFide.Domain.Models
{
    public class Producto
    {
        
        [Key]
        public int IdProducto { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }

        [Required]
        public string Categoria { get; set; }
        [Required]
        public int CantidadDisponible { get; set; }
        [Required]
        public double Precio { get; set; }

        public Proveedor proveedor { get; set; }
        public Marca marca { get; set; }

    }
}
