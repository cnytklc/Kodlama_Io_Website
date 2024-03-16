using KodlamaIo.DataAccess.Abstract;
using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business
{
    public class InstructorManager
    {
        private readonly IInstructors _instructors;

        public InstructorManager(IInstructors instructors)
        {
            _instructors = instructors;
        }

        public List<Instructor> GetAll()
        {
            return _instructors.GetAll();
        }
    }
}
