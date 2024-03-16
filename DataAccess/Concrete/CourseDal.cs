using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIo.DataAccess.Abstract;

namespace KodlamaIo.DataAccess.Concrete
{
    
    public class CourseDal : ICourses
    {
      InstructorDal instructor = new InstructorDal();
        
      
        List<Courses> courses;
        
        public CourseDal()
        {
          
            Courses course1 = new Courses()
            {
                CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
                CourseDescription = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
                CoursePrice = 0,
        };
            Courses course2 = new Courses()
            {
                CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",
                CourseDescription = "1,5 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
                CoursePrice = 0,
            };
            Courses course3 = new Courses()
            {
                CourseName = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)",
                CourseDescription = "Senior Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan",
                CoursePrice = 0,
            };
            Courses course4 = new Courses()
            {
                CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
                CourseDescription = "No Description",
                CoursePrice = 0,
            };
            Courses course5 = new Courses()
            {
                CourseName = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA",
                CourseDescription = "Java Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
                CoursePrice = 0,
            };
            Courses course6 = new Courses()
            {
                CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)",
                CourseDescription = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını",
                CoursePrice = 0,
            };
            Courses course7 = new Courses()
            {
                CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",
                CourseDescription = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını ",
                CoursePrice = 0,
            };
            Courses course8 = new Courses()
            {
                CourseName = "Programlamaya Giriş için Temel Kurs",
                CourseDescription = "PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin.",
                CoursePrice = 0,
            };

            courses = new List<Courses>
            {
                course1, course2, course3, course4, course5, course6, course7, course8
            };

            
           
        }
        public void Add(Courses course)
        {
            courses.Add(course);
        }

        public List<Courses> GetAll()
        {
            return courses;
        }

    }
}
