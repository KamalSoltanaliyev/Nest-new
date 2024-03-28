using Microsoft.AspNetCore.Mvc;

namespace nest_backend.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
