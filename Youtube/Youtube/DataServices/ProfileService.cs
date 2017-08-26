using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube.DataServices.Base;
using Youtube.DataServices.Interfaces;
using Youtube.Models;
using Youtube.Models.Users;

namespace Youtube.DataServices
{
    public class ProfileService : IProfileService
    {

        private readonly IRequestProvider _requestProvider;
        private readonly IAuthenticationService _authenticationService;


        public ProfileService(IRequestProvider requestProvider, IAuthenticationService authenticationService)
        {
            _requestProvider = requestProvider;
            _authenticationService = authenticationService;
        }

        public Task<UserProfile> GetCurrentProfileAsync()
        {
            var userId = _authenticationService.GetCurrentUserId();

            var builder=new UriBuilder(GlobalSettings.AuthenticationEndpoint);
            builder.Path = $"/";

            var uri = builder.ToString();

            return _requestProvider.GetAsync<UserProfile>(uri);
        }

        public async Task UploadUserImageAsync(UserProfile profile, string imageAsBase64)
        {
            var userId = _authenticationService.GetCurrentUserId();

            var builder = new UriBuilder(GlobalSettings.AuthenticationEndpoint);
            builder.Path = $"/";

            var uri = builder.ToString();

            var imageModel = new ImageModel()
            {
                url = imageAsBase64
            };

            await _requestProvider.PutAsync(uri, imageModel);
            // remove cache in here
            //await CacheHelper.RemoveFromCache(profile.PhotoUrl);
        }
    }
}
