using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIo.Entities;

namespace KodlamaIo.DataAccess.Abstract
{
    public interface IInstructors
    {
        void Add(Instructor instructor);

        List<Instructor> GetAll();

    }
}
