using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LawX_Utanganan.Models;

namespace LawX_Utanganan.Controllers;

public class PageController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
