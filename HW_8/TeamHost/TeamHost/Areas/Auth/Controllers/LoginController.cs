using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Web.Areas.Auth.Controllers
{
    [Area("Auth")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
