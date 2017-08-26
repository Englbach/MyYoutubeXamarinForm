using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube.Models.Users;

namespace Youtube.DataServices.Interfaces
{
    public interface IProfileService
    {
        Task<UserProfile> GetCurrentProfileAsync();
        Task UploadUserImageAsync(UserProfile profile, string imageAsBase64);

    }
}
