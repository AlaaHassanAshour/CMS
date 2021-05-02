using CMS.Core.Dto;
using CMS.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Service.Services.Tag
{
    public interface ITagService
    {
        List<TagViewModel> GetAll();
        void Create(CreateTagDto dto);
        void Update(UpdateTagDto dto);
        void Delete(int id);
    }
}
