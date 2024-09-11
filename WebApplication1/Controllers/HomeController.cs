using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult About()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View("Contactus");
        }

        public ViewResult Display()
        {
            return View("~/Views/Accounts/Dashboard.cshtml");
        }

       public ContentResult Greet()
        {
            return Content("This is content a string literal");
        }

        public FileResult Show()
        {
         return File(Server.MapPath("~/Content/content.txt"), "text/plain");
        }

        public FileResult Download()
        {
            return File(Server.MapPath("~/Content/content.txt"), "text/plain" , "MVC5.txt");

        }
        public RedirectResult ShowInternal()
        {
            return Redirect("/home/index");
        }

        public RedirectResult ShowExternal()
        {
            return Redirect("https://www.bkdrluhar.com/");

        }

        public RedirectToRouteResult ShowContact()
        {
            //return RedirectToRoute(new { controller = "home", action = "contact" });
            //return RedirectToAction("contact");
            return RedirectToAction("Dashboard", "Account" );
        }

        public ViewResult List()
        {
            return View();
        }

        //request data collection
        //public contentresult details()
        //{

        //    int x = convert.toint32(request["id"]);
        //    string country = "";
        //    switch (x)
        //    {
        //        case 1: country = "india"; break;
        //        case 2: country = "usa"; break;
        //        case 3: country = "china"; break;
        //        default: country = "you do not belong to any country"; break;

        //    }
        //    return Content(country);



        //}

        //MVC
        public ContentResult details(int id)
        {

            string country = "";
            switch (id)
            {
                case 1: country = "india"; break;
                case 2: country = "usa"; break;
                case 3: country = "china"; break;
                default: country = "you do not belong to any country"; break;

            }
            return Content(country);
        }


        //Request query string
        //public ContentResult Details()
        //{

        //    int x = Convert.ToInt32(Request.QueryString["id"]);
        //    string country = "";
        //    switch (x)
        //    {
        //        case 1: country = "india"; break;
        //        case 2: country = "USA"; break;
        //        case 3: country = "china"; break;
        //        default: country = "You do not belong to any country"; break;

        //    }
        //    return Content(country);
        //}


        public ViewResult Login()
        {
            return View();
        }

        //public ContentResult Validate()
        //{
        //    string u = Request["uname"];
        //    string p = Request["pass"];

        //    if (u == "scott" && p == "tiger")
        //        return Content("Welcome");
        //    else
        //        return Content("sorry");
        //}

        //public ContentResult Validate(FormCollection values)
        //{
        //    string u = values["uname"];
        //    string p = values["pass"];


        //    if (u == "scott" && p == "tiger")
        //        return Content("welcome");
        //    else
        //        return Content("sorry");
        //}

        //** MODEL BINDING **
        public ContentResult Validate(string uname , string pass)
        {
            if (uname == "scott" && pass == "tiger")
                return Content("welcome");
            else
                return Content("sorry");
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ContentResult Register(string name, string email, int age , int phonenumber, string password, string confirmPass)
        {
            if (password == confirmPass)
                return Content("Registered Succesful");
            else
                return Content("Registeration failed");
        }

        public ViewResult Data()
        {
            ViewData["subject"] = "Asp .net web";
            ViewBag.version = 5;

            TempData["language"] = "English";
            TempData["age"] = 52;
            TempData["computer"] = "Ms-office";

            return View();
        }

        public ActionResult Student()
        {
            return View();
        }

        public ActionResult Bootsrapdemo()
        {
            return View();
        }





    }
    
}