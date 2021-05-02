using CMS.Core.Dto;
using CMS.Data;
using CMS.Data.Models;
using CMS.Service.Services.Category;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.API.Controllers
{
    
    public class CategoryController : BaseController
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

   
        [HttpGet]
        public IActionResult GetAll()
        {
           var categories =  _categoryService.GetAll();
           return Ok(categories);
        }

        [HttpPost]
        public IActionResult Create([FromBody]CreateCategoryDto dto)
        {
            _categoryService.Create(dto);
            return Ok("Done");
        }

        [HttpPut]
        public IActionResult Update([FromBody]UpdateCategoryDto entity)
        {
            _categoryService.Update(entity);
            return Ok("Done");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return Ok("Done");
        }

    }
}
