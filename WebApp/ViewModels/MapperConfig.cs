using AutoMapper;
using Domain.Models;

namespace WebApp.ViewModels
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
    }
}
