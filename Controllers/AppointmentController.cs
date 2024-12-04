using HW_ASP_8._3.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW_ASP_8._3.Controllers
{
    public class AppointmentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Appointment());
        }

        [HttpPost]
        public IActionResult Submit(Appointment model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Confirmation", model);
            }

            return View("Index", model);
        }

        [HttpGet]
        public IActionResult Confirmation(Appointment model)
        {
            return View(model);
        }
    }
}
