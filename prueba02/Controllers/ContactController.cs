using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TuProyecto.Models;

namespace TuProyecto.Controllers
{
    public class ContactController : Controller
    {
        // GET: /Contact/
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Contact/
        [HttpPost]
        public IActionResult Index(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                TempData["SuccessMessage"] = "Gracias por contactarnos. Te responderemos lo antes posible.";
                return RedirectToAction("Success");
            }

            return View(model);
        }

        public IActionResult Success()
        {
            ViewBag.SuccessMessage = TempData["SuccessMessage"];

            return View();
        }
    }
}