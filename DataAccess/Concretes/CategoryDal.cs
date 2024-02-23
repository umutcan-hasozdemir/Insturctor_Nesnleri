using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    List<Category> _categories = new List<Category>();
    public CategoryDal()
    {
        Category category1 = new Category();
        category1.CategoryName = "All";

        Category category2 = new Category();
        category2.CategoryName = "Programming";

        _categories = new List<Category> { category1, category2 };
    }

    public void Add(Category category)
    {
        _categories.Add(category);
        _categories.ForEach(category => Console.WriteLine(category.CategoryName));
    }

    public void Delete(Category category)
    {
        Category categoriesToDelete = _categories.SingleOrDefault(c => c.CategoryName == category.CategoryName);

        _categories.Remove(categoriesToDelete);
    }

    public void Update(Category category)
    {
        var categoryName = _categories.FirstOrDefault(c => c.CategoryName == category.CategoryName);
        if (categoryName != null)
        {
            categoryName.CategoryName = category.CategoryName;
        }
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

}
