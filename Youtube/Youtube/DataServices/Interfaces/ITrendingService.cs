using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube.Models;

namespace Youtube.DataServices.Interfaces
{
    public interface ITrendingService
    {
        Task<IEnumerable<TrendingModel.RootObject>> GetTrending(int limit, string paging,string chart);
        Task<IEnumerable<TrendingModel.RootObject>> GetTrendingByLocation();
        Task<IEnumerable<TrendingModel.RootObject>> GetTrendingByPaging(string channelId, string paging, int limit);
        Task<TrendingModel.RootObject> GetInforTrending(string Id);
    }
}
