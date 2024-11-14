using Microsoft.AspNetCore.Mvc;
using RegistrationForm.Models;
using System.Diagnostics;

namespace RegistrationForm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
