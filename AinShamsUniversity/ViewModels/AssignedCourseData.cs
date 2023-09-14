using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AinShamsUniversity.ViewModels
{
    public class AssignedCourseData
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public bool Assigned { get; set; }
    }
}