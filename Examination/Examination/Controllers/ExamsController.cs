using Microsoft.AspNetCore.Mvc;

namespace Examination.Controllers
{
    public class ExamsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {       
            return View();
        }
    }
}