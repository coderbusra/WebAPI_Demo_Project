using AutoMapper;
using WebAPIDemoProject.DTOs;
using WebAPIDemoProject.Model;

namespace WebAPIDemoProject.AutoMapper
{
    public class MapperProfile :Profile
    {
        public MapperProfile()
        {
            CreateMap<Basket, BasketDTO>();
            CreateMap<BasketDTO, Basket>();

            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
        }
    }


}
