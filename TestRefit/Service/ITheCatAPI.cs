using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRefit.Response;

namespace TestRefit.Service
{
    public interface ITheCatAPI
    {
        [Get("/v1/images/search")]
        Task<IEnumerable<SearchResponse>> Search([AliasAs("q")] string breedIdentifier);
    }
}
