using Microsoft.AspNetCore.Mvc;

namespace nest_backend.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }


    }
}
