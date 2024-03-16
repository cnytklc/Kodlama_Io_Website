﻿using KodlamaIo.DataAccess.Concrete;
using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Abstract
{
    public interface ICategory
    {
        void Add(Courses course);
        List<Category> GetAll();

    }
}
