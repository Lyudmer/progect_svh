using Microsoft.AspNetCore.Mvc;
using SVHWebApp.Models;

namespace SVHWebApp.Controllers
{
    public class LogginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Check(User user)
        {
            if (ModelState.IsValid)
            {
               //подключение бд
            }
            return View("Index");
        }
    
}
}
