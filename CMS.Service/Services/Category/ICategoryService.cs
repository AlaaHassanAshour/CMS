using CMS.Core.Dto;
using CMS.Core.ViewModel;
using CMS.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Service.Services.Category
{
    public interface ICategoryService
    {
        List<CategoryViewModel> GetAll();

        void Delete(int id);

        void Create(CreateCategoryDto dto);

        void Update(UpdateCategoryDto entity);

    }
}
