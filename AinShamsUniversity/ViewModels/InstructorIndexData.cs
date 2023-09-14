using AinShamsUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;

namespace AinShamsUniversity.ViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }

        internal object ToPagedList(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}