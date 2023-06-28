using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }
    }
}
