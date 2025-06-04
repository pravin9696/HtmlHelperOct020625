using HtmlHelperOct020625.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelperOct020625.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //This method execute First time when user request ViewPage(Html Page) using URL
        [HttpGet]         
        public ActionResult AddStudent()
        {
          //  Student s = new Student() { RollNo=1,Name="Rajesh",TotalMarks=480};
            return View();
        }


        //// It execute when User inserts records into ViewPage(Html Page) and submit it to the Server
        [HttpPost]
        public ActionResult AddStudent(Student st)
        {
            //  Student s = new Student() { RollNo=1,Name="Rajesh",TotalMarks=480};
            return View();
        }

        [HttpGet]
        public ActionResult AddEmp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmp(Employee e)
        {
            // CRUD
            return View();
        }
    }
}