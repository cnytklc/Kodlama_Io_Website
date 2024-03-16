using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIo.DataAccess.Abstract;
using KodlamaIo.DataAccess.Concrete;
using KodlamaIo.Entities;

namespace KodlamaIo.Business
{
    public class CoursesManager
    {
        private readonly ICourses _courses;

        public CoursesManager(ICourses courses)
        {
            _courses = courses;
        }

        public List<Courses> GetAll()
        {
            return _courses.GetAll();
        }
    }
}
