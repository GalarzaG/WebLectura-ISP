using Microsoft.AspNetCore.Mvc;

namespace WebLectura.Controllers
{
    public class RevistasController : Controller
    {
        public IActionResult Revista()
        {
            return View();
        }
    }
}
