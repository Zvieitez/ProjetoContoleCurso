using Microsoft.AspNetCore.Mvc;

namespace ControleCursoImpacta.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Curso()
        {
            return View();
        }
    }
}
