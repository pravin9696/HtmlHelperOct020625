using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HtmlHelperOct020625.Models
{
    public class Student
    {
        public int RollNo { get; set; }
        public String Name { get; set; }
        public int  TotalMarks { get; set; }
        public String Address { get; set; }
        public bool MessRequired { get; set; }
        public bool HostelRequired { get; set; }
        public String  course { get; set; }
    }
}