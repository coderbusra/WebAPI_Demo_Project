using Microsoft.AspNetCore.Mvc;
using WebAPIDemoProject.Model;

namespace WebAPIDemoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        Context context = new Context();
        [HttpGet("[action]")]
        public IActionResult GetList()
        {
            var result = context.Baskets.ToList();
            return Ok(result);
        }

        [HttpPost("[action]")]
        public IActionResult Add(Basket basket) 
        {
            context.Baskets.Add(basket);
            context.SaveChanges();
            return Ok("Sepete ürün başarıyla eklendi");
        }

        //adresim/api/Baskets/Delete?id=5
        //adresim/api/Baskets/Delete/id=5
        [HttpGet("[action]/{id}")]
        public IActionResult Delete(int id)
        {
            var result = context.Baskets.Where(p => p.Id == id).FirstOrDefault();
            context.Baskets.Remove(result);
            context.SaveChanges();

            var liste = context.Baskets.ToList();
            return Ok(liste);
        }
    }
}
