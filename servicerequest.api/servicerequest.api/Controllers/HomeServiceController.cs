using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using servicerequest.api.Interfaces;
using servicerequest.api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace servicerequest.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeServiceController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeServiceController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet]
        [Route("GetServiceRequests")]
        public async Task<IEnumerable<ServiceRequests>> GetServiceRequests()
        {
            var serviceRequests = await _homeService.ListAsync();

            return serviceRequests;
        }

        [HttpGet]
        [Route("GetCategories")]
        public async Task<IEnumerable<Product>> GetServiceCategories()
        {
            var ProductList = await _homeService.ProductListAsync();

            return ProductList;
        }

        [HttpGet]
        [Route("GetProductTypes")]
        public async Task<IEnumerable<ProductType>> GetProductTypes()
        {
            var ProductTypeList = await _homeService.ProductTyeListAsync();

            return ProductTypeList;
        }

        [HttpGet]
        [Route("GetProductService")]
        public async Task<IEnumerable<ProductServices>> GetProductService()
        {
            var ProductTypeList = await _homeService.ProductServiceListAsync();

            return ProductTypeList;
        }


        [HttpPost]
        [Route("SaveServiceRequest")]
        public async Task<IActionResult> PostAsync([FromBody]ServiceRequests serviceRequest)
        {
            var result = await _homeService.SaveAsync(serviceRequest);

            if (!result.Success)
                return BadRequest(result.Message);

            return Ok(result.ServiceRequests);
        }

    }
}