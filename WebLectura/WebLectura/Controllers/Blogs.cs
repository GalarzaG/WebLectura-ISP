using Microsoft.AspNetCore.Mvc;

namespace WebLectura.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
    }
}
