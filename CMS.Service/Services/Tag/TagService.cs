using CMS.Core.Dto;
using CMS.Core.ViewModel;
using CMS.Data;
using CMS.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Service.Services.Tag
{
    public class TagService : ITagService
    {
        private ApplicationDbContext _DB;
        
        public TagService(ApplicationDbContext DB)
        {
            _DB = DB;
        }

        public List<TagViewModel> GetAll()
        {
            var tagVm = _DB.Tags.Select(x => new TagViewModel() { 
               Id = x.Id,
               Name = x.Name
            }).ToList();

            return tagVm;
        }

        public void Create(CreateTagDto dto)
        {
            var tag = new TagDbEntity();
            tag.Name = dto.Name;
            _DB.Tags.Add(tag);
            _DB.SaveChanges();
        }

        public void Update(UpdateTagDto dto)
        {
            var tag = _DB.Tags.SingleOrDefault(X => X.Id == dto.Id && !X.IsDelete);
            tag.Name = dto.Name;
            _DB.Tags.Update(tag);
            _DB.SaveChanges();
        }

        public void Delete(int id)
        {
            var tag = _DB.Tags.SingleOrDefault(X => X.Id == id && !X.IsDelete);
            tag.IsDelete = true;
            _DB.Tags.Update(tag);
            _DB.SaveChanges();
        }



    }
}
