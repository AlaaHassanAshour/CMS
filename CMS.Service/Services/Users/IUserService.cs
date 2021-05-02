using CMS.Core.Dto;
using CMS.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Service.Services.User
{
    public interface IUserService
    {
        List<UserViewModel> GetUsers();
        Task<bool> Create(CreateUserDto dto);
        Task Update(UpdateUserDto dto);
        void Delete(string Id);
    }
}
