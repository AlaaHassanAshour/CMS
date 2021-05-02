using CMS.Core.Dto;
using CMS.Core.Exceptions;
using CMS.Core.ViewModel;
using CMS.Data;
using CMS.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Service.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private ApplicationDbContext _DB;

        public CategoryService(ApplicationDbContext DB)
        {
            _DB = DB;
        }

        public List<CategoryViewModel> GetAll()
        {
            throw new InvalidUsernameException();

            var categoriesVm = _DB.Categories.Select(x => new CategoryViewModel() { 
              Id = x.Id,
              Name= x.Name,
              CreatedAt = x.CreatedAt
            }).ToList();

            return categoriesVm;
        }

        public void Create(CreateCategoryDto dto)
        {
            var category = new CategoryDbEntity();
            category.Name = dto.Name;
            _DB.Categories.Add(category);
            _DB.SaveChanges();
        }

        public void Update(UpdateCategoryDto dto)
        {
            var category = _DB.Categories.SingleOrDefault(x => x.Id == dto.Id && !x.IsDelete);
            category.Name = dto.Name;
            _DB.Categories.Update(category);
            _DB.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = _DB.Categories.SingleOrDefault(x => x.Id == id && !x.IsDelete);
            category.IsDelete = true;
            _DB.Categories.Update(category);
            _DB.SaveChanges();
        }
    }
}
