using Microsoft.AspNetCore.Mvc;

namespace ClinicaVida.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => RedirectToAction("Index", "Especialidades");

    public IActionResult Error() => View();
}
