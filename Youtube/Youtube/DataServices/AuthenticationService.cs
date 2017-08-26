using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube.DataServices.Base;
using Youtube.DataServices.Interfaces;
using Youtube.Helpers;
using Youtube.Models.Users;

namespace Youtube.DataServices
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IRequestProvider _requestProvider;

        public bool isAuthenticated => !string.IsNullOrEmpty(Settings.AccessToken);

        public AuthenticationService(IRequestProvider requestProvider)
        {
            _requestProvider = requestProvider;
        }
        
        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }

        public int GetCurrentUserId()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <returns></returns>
        public Task<bool> LoginAsync()
        {
            var auth = new AuthenticationRequest
            {
                client_id = GlobalSettings.Client_ID,
                redirect_uri = GlobalSettings.Redirect_Uri,
                scope = "code"
            };

            UriBuilder builder=new UriBuilder(GlobalSettings.AuthenticationEndpoint);
            //builder.Path = "Client_ID=" + GlobalSettings.Client_ID + "&Client_Serect=" + GlobalSettings.Client_Serect;
            string uri = builder.ToString();

            

            return Task.FromResult(true);

        }
    }
}