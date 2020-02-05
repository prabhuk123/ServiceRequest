using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using servicerequest.api.Contexts;
using servicerequest.api.Models;
using servicerequest.api.Response;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace servicerequest.api.Repository
{
    public class HomeServiceRepository : BaseRepository, IHomeServiceRepository
    {
        public HomeServiceRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<ServiceRequests>> ListAsync()
        {

            return await _context.ServiceRequests.ToListAsync();
        }

        public async Task AddAsync(ServiceRequests serviceRequests)
        {
            _context.ServiceRequests.Add(serviceRequests);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> ProductListAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<IEnumerable<ProductType>> ProductTypeListAsync()
        {
            return await _context.ProductTypes.ToListAsync();
        }

        public async Task<IEnumerable<ProductServices>> ProductServicesListAsync()
        {
            return await _context.ProductServices.ToListAsync();
        }
    }
}
