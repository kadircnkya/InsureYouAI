using Microsoft.AspNetCore.Mvc;

namespace InsureYouAINew.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
