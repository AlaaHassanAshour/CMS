using CMS.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<PostTagDbEntity>().HasKey(x => new { x.PostId,x.TagId });
            builder.Entity<CategoryDbEntity>().HasQueryFilter(x => !x.IsDelete);
            builder.Entity<PostDbEntity>().HasQueryFilter(x => !x.IsDelete);
            builder.Entity<TagDbEntity>().HasQueryFilter(x => !x.IsDelete);
        }

        //Define Database Tables

        public DbSet<PostDbEntity> Posts { get; set; }
        public DbSet<CategoryDbEntity> Categories { get; set; }
        public DbSet<PostImageDbEntity> PostImages { get; set; }
        public DbSet<TagDbEntity> Tags { get; set; }
        public DbSet<PostTagDbEntity> PostTags { get; set; }
    }
}
