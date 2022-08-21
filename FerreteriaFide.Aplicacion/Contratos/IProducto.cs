using FerreteriaFide.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaFide.Aplicacion.Contratos
{
    public interface IProducto
    {
        List<Producto> GetProductos();
        Producto GetProducto(int IdProducto);

        void AddProducto(Producto producto);
    }
}
