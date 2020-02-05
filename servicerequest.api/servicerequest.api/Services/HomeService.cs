using servicerequest.api.Interfaces;
using servicerequest.api.Models;
using servicerequest.api.Repository;
using servicerequest.api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servicerequest.api.Services
{
    public class HomeService : IHomeService
    {

        private readonly IHomeServiceRepository _homeServiceRepository;

        public HomeService(IHomeServiceRepository homeServiceRepository)
        {
            this._homeServiceRepository = homeServiceRepository;
        }

        public async Task<IEnumerable<Product>> ProductListAsync()
        {
            return await _homeServiceRepository.ProductListAsync();
        }

        public async Task<IEnumerable<ProductType>> ProductTyeListAsync()
        {
            return await _homeServiceRepository.ProductTypeListAsync();
        }

        public async Task<IEnumerable<ServiceRequests>> ListAsync()
        {
            return await _homeServiceRepository.ListAsync();
        }

        public async Task<SaveServiceRequestsResponse> SaveAsync(ServiceRequests serviceRequests)
        {
            try
            {
                await _homeServiceRepository.AddAsync(serviceRequests);

                return new SaveServiceRequestsResponse(serviceRequests);
            }
            catch (Exception ex)
            {
                return new SaveServiceRequestsResponse($"An error occured whil saving service request: {ex.Message}");
            }
        }

        public async Task<IEnumerable<ProductServices>> ProductServiceListAsync()
        {
            return await _homeServiceRepository.ProductServicesListAsync();
        }
    }
}
