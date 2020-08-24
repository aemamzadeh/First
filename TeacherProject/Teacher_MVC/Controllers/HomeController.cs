using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Teacher_MVC.Models;

namespace Teacher_MVC.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Contact(Contact form)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده معتبر نمیباشد. دوباره تلاش نمایید.";
                return View(form);
            }
            //return RedirectToAction("Index");
            ViewBag.success = "پیام شما با موفقیت ارسال شد.";
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
