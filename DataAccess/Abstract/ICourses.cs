using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIo.DataAccess.Concrete;

namespace KodlamaIo.DataAccess.Abstract
{
    public interface ICourses
    {
        void Add(Courses course);
        List<Courses> GetAll();

    }
}
