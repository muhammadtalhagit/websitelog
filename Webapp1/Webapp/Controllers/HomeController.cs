using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Webapp.Models;

namespace Webapp.Controllers
{
    public class HomeController : Controller
    {
         

        public IActionResult Index()
        {
			if (HttpContext.Session.GetString("role") == "user")
			{
				ViewBag.email = HttpContext.Session.GetString("userEmail");
				return View();
			}
			else
			{
				return RedirectToAction("Login","Admin");
			}

		}

		public IActionResult About()
        {
			if (HttpContext.Session.GetString("role") == "user")
			{
				ViewBag.email = HttpContext.Session.GetString("userEmail");
				return View();
			}
			else
			{
				return RedirectToAction("Login", "Admin");
			}
		}

		public IActionResult Shop()
		{
			if (HttpContext.Session.GetString("role") == "user")
			{
				ViewBag.email = HttpContext.Session.GetString("userEmail");
				return View();
			}
			else
			{
				return RedirectToAction("Login", "Admin");
			}
		}

		public IActionResult Services()
		{
			if (HttpContext.Session.GetString("role") == "user")
			{
				ViewBag.email = HttpContext.Session.GetString("userEmail");
				return View();
			}
			else
			{
				return RedirectToAction("Login", "Admin");
			}
		}

		public IActionResult Blog()
		{
			if (HttpContext.Session.GetString("role") == "user")
			{
				ViewBag.email = HttpContext.Session.GetString("userEmail");
				return View();
			}
			else
			{
				return RedirectToAction("Login", "Admin");
			}
		}

		public IActionResult Contact()
		{
			if (HttpContext.Session.GetString("role") == "user")
			{
				ViewBag.email = HttpContext.Session.GetString("userEmail");
				return View();
			}
			else
			{
				return RedirectToAction("Login", "Admin");
			}
		}
        public IActionResult Cart()
        {
			if (HttpContext.Session.GetString("role") == "user")
			{
				ViewBag.email = HttpContext.Session.GetString("userEmail");
				return View();
			}
			else
			{
				return RedirectToAction("Login", "Admin");
			}
		}
        public IActionResult Checkout()
        {
			if (HttpContext.Session.GetString("role") == "user")
			{
				ViewBag.email = HttpContext.Session.GetString("userEmail");
				return View();
			}
			else
			{
				return RedirectToAction("Login", "Admin");
			}
		}

		public IActionResult thankyou()
		{
			if (HttpContext.Session.GetString("role") == "user")
			{
				ViewBag.email = HttpContext.Session.GetString("userEmail");
				return View();
			}
			else
			{
				return RedirectToAction("Login", "Admin");
			}
		}

		public IActionResult LogoutAdmin()
		{
			HttpContext.Session.Clear();
			HttpContext.Session.Remove("role");
			HttpContext.Session.Remove("userEmail");

			return RedirectToAction("Login","Admin");

		}
	}
}
