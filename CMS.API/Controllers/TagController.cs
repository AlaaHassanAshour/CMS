using CMS.Core.Dto;
using CMS.Core.ViewModel;
using CMS.Service.Services.Tag;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.API.Controllers
{
   
    public class TagController : BaseController
    {
        private ITagService _tagService;

        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var tages = _tagService.GetAll();
            return Ok(GetRespons(tages));
        }

        [HttpPost]
        public IActionResult Create([FromBody]CreateTagDto dto)
        {

            _tagService.Create(dto);
            return Ok(GetRespons(null,"Addess Suceefuly"));
        }

        [HttpPut]
        public IActionResult Update([FromBody]UpdateTagDto dto)
        {
            _tagService.Update(dto);
            return Ok(GetRespons());
        }

        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            _tagService.Delete(Id);
            return Ok(GetRespons());
        }
    }
}
