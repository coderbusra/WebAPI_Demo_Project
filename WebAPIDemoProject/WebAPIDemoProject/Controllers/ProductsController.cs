using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDemoProject.DTOs;
using WebAPIDemoProject.Model;

namespace WebAPIDemoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //sisteminadi/api/Urunlerim/
    public class ProductsController : ControllerBase
    {
        Context context = new Context();
        //Mevcut ürünlerin listesini almak için
        private readonly IMapper _mapper;
        public ProductsController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            List<Product> products = new List<Product>();
            products = context.Products.ToList();
            return Ok(products);
        }

        

        [HttpPost("Add")]
        public IActionResult Add(ProductDTO productDTOs)
        {
            var product = _mapper.Map<Product>(productDTOs);
            context.Add(product);
            context.SaveChanges();
            return Ok("İşlem başarılı");
        }

        //Ürün ekleme
        //[HttpPost("Add")]
        //public IActionResult Add(Product product)
        //{
        //    context.Add(product);
        //    context.SaveChanges();
        //    return Ok("İşlem Başarılı");

        //}

        //[HttpPost("Add")]
        //public IActionResult Add(List<ProductDTO> productDTOs)
        //{
        //    var product = _mapper.Map<List<ProductDTO>, List<Product>>(productDTOs);
        //    context.Add(product);
        //    context.SaveChanges();
        //    return Ok("İşlem başarılı");
        //}

        [HttpGet("Delete")]
        public IActionResult Delete(int id) 
        {
            var product = context.Products.FirstOrDefault(x => x.Id == id);
            context.Remove(product);
            context.SaveChanges();
            return Ok("Ürün başarıyla silindi");
        }
    }
}
