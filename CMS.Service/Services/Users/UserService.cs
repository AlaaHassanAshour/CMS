using CMS.Core.Dto;
using CMS.Core.ViewModel;
using CMS.Data;
using CMS.Service.Services.User;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Service.Services.Users
{
    public class UserService : IUserService
    {
        private ApplicationDbContext _DB;
        private UserManager<CMS.Data.Models.User> _userManager;

        public UserService(ApplicationDbContext DB, UserManager<CMS.Data.Models.User> userManager)
        {
            _DB = DB;
            _userManager = userManager;
        }

        public List<UserViewModel> GetUsers()
        {
            var users = _DB.Users.Where(x => !x.IsDelete).Select(x => new UserViewModel()
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                DOB = x.DOB
            }).ToList();

            return users;
        }
        public async Task<bool> Create(CreateUserDto dto)
        {
            var user = new CMS.Data.Models.User();
            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.Email = dto.Email;
            user.PhoneNumber = dto.PhoneNumber;
            user.DOB = dto.DOB;
            user.CreatedAt = DateTime.Now;
            user.UserName = dto.PhoneNumber;

            var result = await _userManager.CreateAsync(user, "Ahmed11$$");

            return result.Succeeded;
        }
        public async Task Update(UpdateUserDto dto)
        {
            var user = _DB.Users.SingleOrDefault(x => x.Id == dto.Id && !x.IsDelete);
            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.Email = dto.Email;
            user.DOB = dto.DOB;
            user.CreatedAt = DateTime.Now;

            await _userManager.UpdateAsync(user);
        }
        public void Delete(string Id)
        {
            var user = _DB.Users.SingleOrDefault(x => x.Id == Id && !x.IsDelete);
            user.IsDelete = true;
            _DB.Users.Update(user);
            _DB.SaveChanges();
        }
    }
}