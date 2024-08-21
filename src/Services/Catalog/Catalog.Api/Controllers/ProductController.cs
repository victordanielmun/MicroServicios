﻿using Catalog.Services.Queries;
using Catalog.Services.Queries.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Common.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {

        private readonly IProductQueryService _productQueryService;
        private readonly ILogger<DefaultController> _logger;

        public ProductController(
            ILogger<DefaultController> logger,
            IProductQueryService productQueryService)
        {
            _logger = logger;
            _productQueryService = productQueryService;
        }

        [HttpGet]
        public async Task<DataCollection<ProductDto>> GetAll(int page=1, int take = 10, string ids = null)
        {
            IEnumerable<int> products = null;

            if (!string.IsNullOrEmpty(ids))
            {
                products = ids.Split(',').Select(x => Convert.ToInt32(x));
            }

            return await _productQueryService.GetAllAsync(page, take, products);
        }

        [HttpGet("{id}")]
        public async Task<ProductDto> Get(int id)
        {
            return await _productQueryService.GetAsync(id);
        }

    }
}
