using CMS.Core.Dto;
using CMS.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Service.Services.Auth
{
    public interface IAuthService
    {
        Task<LoginResponseViewModel> LoginAsync(LoginDto dto);

        Task SaveFcmToken(string fcm, string userId);


    }
}
