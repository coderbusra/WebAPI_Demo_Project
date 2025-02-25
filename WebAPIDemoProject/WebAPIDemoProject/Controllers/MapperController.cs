using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDemoProject.DTOs;
using WebAPIDemoProject.Model;

namespace WebAPIDemoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapperController : ControllerBase
    {
        private readonly IMapper _mapper;
        public MapperController(IMapper mapper)
        {
            _mapper = mapper;
        }

         [HttpPost]
        public IActionResult Post(List<ProductDTO> productDTOs)
        {
            List<Product> product = _mapper.Map<List<ProductDTO>, List<Product>>(productDTOs);
            return Ok(product);
        }
    }
}
