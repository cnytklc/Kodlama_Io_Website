using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIo.DataAccess.Abstract;
using KodlamaIo.Entities;

namespace KodlamaIo.DataAccess.Concrete
{
    public class InstructorDal :IInstructors
    {
        private List<Instructor> instructors;
        public InstructorDal()
        {
            Instructor instructor1 = new Instructor();
            instructor1.InstructorFirstName = "Engin";
            instructor1.InstructorLastName = "Demiroğ";

            Instructor instructor2 = new Instructor();
            instructor2.InstructorFirstName = "Halit Enes";
            instructor2.InstructorLastName = "Kalaycı";

          instructors =  new List<Instructor> { instructor1, instructor2 };
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }
    }
}
