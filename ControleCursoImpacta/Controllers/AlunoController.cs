using Microsoft.AspNetCore.Mvc;

namespace ControleCursoImpacta.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Aluno()
        {
            return View();
        }
    }
}
