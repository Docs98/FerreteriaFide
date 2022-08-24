using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ferreteria_Fide.Marca
{
    public class EditarMarcaController : Controller
    {
        public IActionResult Index(FerreteriaFide.Domain.Models.Marca marca)
        {
            return View(marca);
        }

        [HttpPost]
        public async Task<IActionResult> EditMarca(FerreteriaFide.Domain.Models.Marca marca)
        {
            return RedirectToAction("Index", "Marca");
        }
    }
}
