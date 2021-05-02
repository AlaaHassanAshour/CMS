using CMS.Core.Dto;
using CMS.Service.Services.Post;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.API.Controllers
{

    public class PostController : BaseController
    {
        private IPostServies _PostSerives;

        public PostController(IPostServies postSerives)
        {
            _PostSerives = postSerives;
        }

        [HttpGet]
        public IActionResult GetAllPosts(int page = 1)
        {
           var posts =  _PostSerives.GetAll(page);
            return Ok(GetRespons(posts,"Done"));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromForm]CreatePostDto dto)
        {
            await _PostSerives.Create(dto);
            return Ok(GetRespons());
        }

        [HttpDelete]

        public IActionResult Delete (int id)
        {
            _PostSerives.Delete(id);

            return Ok(GetRespons(null, "Done"));
        }


    }
}
