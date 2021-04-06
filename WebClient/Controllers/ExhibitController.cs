using Microsoft.AspNetCore.Mvc;

namespace WebClient.Controllers
{
    public class ExhibitController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}