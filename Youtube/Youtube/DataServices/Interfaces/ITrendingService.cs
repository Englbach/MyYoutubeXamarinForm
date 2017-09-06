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
        Task<IEnumerable<TrendingModel.Root>> GetTrending(int limit, string paging,string chart);
        Task<IEnumerable<TrendingModel.Root>> GetTrendingByLocation();
        Task<IEnumerable<TrendingModel.Root>> GetTrendingByPaging(string channelId, string paging, int limit);
        Task<TrendingModel.Root> GetInforTrending(string Id);
    }
}
