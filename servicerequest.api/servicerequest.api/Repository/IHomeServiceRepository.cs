using servicerequest.api.Models;
using servicerequest.api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servicerequest.api.Repository
{
    public interface IHomeServiceRepository
    {
        Task<IEnumerable<ServiceRequests>> ListAsync();
        Task AddAsync(ServiceRequests serviceRequests);

        Task<IEnumerable<Product>> ProductListAsync();

        Task<IEnumerable<ProductType>> ProductTypeListAsync();

        Task<IEnumerable<ProductServices>> ProductServicesListAsync();
    }
}
