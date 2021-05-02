using CMS.Core.Dto;
using CMS.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Service.Services.Post
{
  public  interface IPostServies
    {
        PagingViewModel GetAll(int page);
        void Delete(int id);
        Task Create(CreatePostDto dto);
    }
}
