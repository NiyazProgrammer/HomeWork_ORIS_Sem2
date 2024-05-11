using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Web.Areas.Auth.Controllers
{
    [Area("Auth")]
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
