using HtmlHelperOct020625.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelperOct020625.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index1(string txtName, string txtLastName,int txtAge)
        {
            return View();
        }

        public ActionResult Method1()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CheckBoxDemo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckBoxDemo(bool Marathi,Boolean Hindi,bool English)
        {
            return View();
        }

        [HttpGet]
        public ActionResult RadioButtonDemo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RadioButtonDemo(String Gender,String Course)
        {
            return View();
        }
        [HttpGet]
        public ActionResult DropDownListDemo()
        {
            List<PrgLanguages> PrgLangs = new List<PrgLanguages>() { 
            new PrgLanguages(){ ID=1, Name="JAVA"},
            new PrgLanguages(){ ID=2,Name="Dot Net"},
            new PrgLanguages(){ ID=3,Name="Python"},
            };
            List<String> Cities = new List<string>()
            {
                "Pune","Nashik","Nagar"
            };
            ViewBag.cityList = Cities;
            ViewBag.PrgLangList = PrgLangs;
            return View();
        }
        [HttpPost]
        public ActionResult DropDownListDemo(int course,String OtherCourse,String City)
        {
            return View();
        }
    }
}