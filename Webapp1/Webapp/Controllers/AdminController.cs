using Microsoft.AspNetCore.Mvc;

namespace Webapp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
                            
        }

        public IActionResult Addproduct()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }

        }

        public IActionResult Widgets()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Forms()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Tables()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Charts()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Signin()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Signup()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Error()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.email = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Blank()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        [ValidateAntiForgeryToken]

        public IActionResult Login(string email, string pass)
        {
           if(email == "admin@gmail.com" && pass == "123")
            {
                HttpContext.Session.SetString("adminEmail", email);
                HttpContext.Session.SetString("role", "admin");
                return RedirectToAction("Index");
            }
            else if(email == "user@gmail.com" && pass == "123")
            {
                HttpContext.Session.SetString("userEmail", email);
                HttpContext.Session.SetString("role", "user");
                return RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.msg = "Invalid Credentials";
                return View();
            }
        }
         

        public IActionResult LogoutAdmin()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("role");
            HttpContext.Session.Remove("adminEmail");

            return RedirectToAction("Login");
       
        }  
    }
}
