using Microsoft.AspNetCore.Mvc;

namespace WebLectura.Controllers
{
    public class LibrosController : Controller
    {
        public IActionResult Libro()
        {
            return View();
        }
    }
}
