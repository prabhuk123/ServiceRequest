using servicerequest.api.Models;
using servicerequest.api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servicerequest.api.Interfaces
{
    public interface IHomeService
    {
        Task<IEnumerable<ServiceRequests>> ListAsync();
        Task<SaveServiceRequestsResponse> SaveAsync(ServiceRequests serviceRequests);

        Task<IEnumerable<Product>> ProductListAsync();

        Task<IEnumerable<ProductType>> ProductTyeListAsync();

        Task<IEnumerable<ProductServices>> ProductServiceListAsync();
    }
}
