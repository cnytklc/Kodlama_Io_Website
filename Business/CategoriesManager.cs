using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIo.DataAccess.Abstract;
using KodlamaIo.Entities;

namespace KodlamaIo.Business
{
    public class CategoriesManager
    {
        private readonly ICategory _category;

        public CategoriesManager(ICategory category)
        {
            _category = category;
        }

     public List<Category> GetAll()
     {
         return _category.GetAll();
     }

    }
}
