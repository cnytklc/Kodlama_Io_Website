using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIo.DataAccess.Abstract;
using KodlamaIo.Entities;

namespace KodlamaIo.DataAccess.Concrete
{
    public class CategoryDal : ICategory
    {
        List<Category> _categories;
        public CategoryDal()
        {
            Category category1 = new Category()
            {
                Name = "Tümü",
                Id = 1
            };

            Category category2 = new Category()
            {
                Name = "Programlama",
                Id = 2
            };
            _categories = new List<Category> { category1, category2 };
        }

        public void Add(Courses course)
        {
            
        }

        public List<Category> GetAll()
        {
            return _categories;
        }
    }
}
