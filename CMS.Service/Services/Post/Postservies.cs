using CMS.Core.Dto;
using CMS.Core.ViewModel;
using CMS.Data;
using CMS.Data.Models;
using CMS.Service.Files;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Service.Services.Post
{
    public class Postservies : IPostServies
    {
        private ApplicationDbContext _Db;
        private IFileService _fileService;

        public Postservies(ApplicationDbContext db, IFileService fileService)
        {
            _Db = db;
            _fileService = fileService;
        }
        public PagingViewModel GetAll(int page)
        {

            var pages = Math.Ceiling(_Db.Posts.Count() / 10.0);


            if (page < 1 || page > pages)
            {
                page = 1;
            }

            var skip = (page - 1) * 10;

            var posts = _Db.Posts.Include(x => x.PostImages).Include(x => x.Category).Include(x => x.PostTags)
                .ThenInclude(x => x.Tag).Select(x => new PostViewModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    Body = x.Body,
                    Category = new CategoryViewModel()
                    {
                        Id = x.Category.Id,
                        Name = x.Category.Name,
                        CreatedAt = x.Category.CreatedAt
                    },
                    Tags = x.PostTags.Select(v => new TagViewModel()
                    {
                        Id = v.Tag.Id,
                        Name = v.Tag.Name
                    }).ToList(),
                    Images = x.PostImages.Select(x => x.ImageUrl).ToList()
                }).Skip(skip).Take(10).ToList();

            var pagingResult = new PagingViewModel();
            pagingResult.Data = posts;
            pagingResult.NumberOfPages = (int)pages;
            pagingResult.CureentPage = page;

            return pagingResult;
        }

        public async Task Create(CreatePostDto dto)
        {

            var createdPost = new PostDbEntity()
            {
                Title = dto.Title,
                Body = dto.Body,
                CategoryId = dto.CategoryId
            };

            _Db.Posts.Add(createdPost);
            _Db.SaveChanges();

            foreach (var x in dto.TagsId)
            {
                var postTag = new PostTagDbEntity();
                postTag.PostId = createdPost.Id;
                postTag.TagId = x;
                _Db.PostTags.Add(postTag);
            }

            foreach (var img in dto.Images)
            {
                var imgName = await _fileService.SaveFile(img, "Images");

                var postImage = new PostImageDbEntity();
                postImage.PostId = createdPost.Id;
                postImage.ImageUrl = imgName;

                _Db.PostImages.Add(postImage);
            }
            _Db.SaveChanges();
        }
        
        public async Task Update(CreatePostDto dto)
        {

            var createdPost = new PostDbEntity()
            {
                Title = dto.Title,
                Body = dto.Body,
                CategoryId = dto.CategoryId
            };

            _Db.Posts.Update(createdPost);

            var postTage = await _Db.PostTags.Where(x => x.PostId == dto.Id).ToListAsync();
            _Db.PostTags.RemoveRange(postTage);
            _Db.SaveChanges();
            foreach (var x in dto.TagsId)
            {
                var postTag = new PostTagDbEntity();
                postTag.PostId = createdPost.Id;
                postTag.TagId = x;
                _Db.PostTags.Add(postTag);
            }
            _Db.SaveChanges();
        }
        public void Delete(int id)
        {
            var deletedPost = _Db.Posts.SingleOrDefault(x => x.Id == id);
            deletedPost.IsDelete = true;
            _Db.Posts.Update(deletedPost);
            _Db.SaveChanges();
        }
    }

}
