using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using productservice.data;

namespace productservice.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private AppDBContext appDBContext;
        public ProductController(AppDBContext _appDBContext)
        {
            appDBContext = _appDBContext;
        }
        [HttpGet]
        [Route("GetProducts")]
        public IActionResult GetProducts()
        {
            return Ok(appDBContext.products.ToList());
        }
    }
}