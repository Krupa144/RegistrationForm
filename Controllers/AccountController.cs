using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    [HttpGet]
    public IActionResult Register()
    {
        return View();  
    }

    [HttpPost]
    public IActionResult Register(RegistrationViewModel model)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("RegistrationSuccess");
        }
        return View(model);
    }
}


