using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class PrivacyPolicyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
