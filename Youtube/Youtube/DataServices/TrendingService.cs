using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube.DataServices.Base;
using Youtube.DataServices.Interfaces;
using Youtube.Models;

namespace Youtube.DataServices
{
    public class TrendingService : ITrendingService
    {
        private readonly IRequestProvider _requestProvider;
        private readonly IAuthenticationService _authenticationService;



        public TrendingService(IRequestProvider requestProvider, IAuthenticationService authenticationService)
        {
            _requestProvider = requestProvider;
            _authenticationService = authenticationService;
        }

        public async Task<IEnumerable<TrendingModel.RootObject>> GetTrending(int limit, string paging, string chart)
        {
            string builder = String.Format("https://www.googleapis.com/youtube/v3/videos/?chart={0}&part={1}&key={2}&maxResults={3}", chart, "snippet, contentDetails, statistics, status", GlobalSettings.Key,GlobalSettings.MaxResult);

            IEnumerable<TrendingModel.RootObject> trending = await _requestProvider.GetAsync<IEnumerable<TrendingModel.RootObject>>(builder);

            return trending;
        }

        public Task<IEnumerable<TrendingModel.RootObject>> GetTrendingByLocation()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TrendingModel.RootObject>> GetTrendingByPaging(string channelId, string paging, int limit)
        {
            throw new NotImplementedException();
        }

        public Task<TrendingModel.RootObject> GetInforTrending(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
