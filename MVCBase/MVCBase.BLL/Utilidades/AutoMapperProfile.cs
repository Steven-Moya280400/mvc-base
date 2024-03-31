using AutoMapper;
using MVCBase.Models.DTOs;
using MVCBase.Models.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBase.BLL.Utilidades
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CategoriaDTO, CategoriaModel>()
                .ForMember(dest => dest.IdCategoria, opt => opt.MapFrom(src => src.IdCategoria))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion));

            CreateMap<CategoriaModel, CategoriaDTO>()
                .ForMember(dest => dest.IdCategoria, opt => opt.MapFrom(src => src.IdCategoria))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion));

            CreateMap<JuegoDTO, JuegoModel>()
                .ForMember(dest => dest.IdJuego, opt => opt.MapFrom(src => src.IdCategoria))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
                .ForMember(dest => dest.FechaLanzamiento, opt => opt.MapFrom(src => src.FechaLanzamiento))
                .ForMember(dest => dest.IdCategoria, opt => opt.MapFrom(src => src.IdCategoria))
                .ForMember(dest => dest.Categoria, opt => opt.MapFrom(src => src.Categoria));

            CreateMap<JuegoModel, JuegoDTO>()
                .ForMember(dest => dest.IdJuego, opt => opt.MapFrom(src => src.IdCategoria))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
                .ForMember(dest => dest.FechaLanzamiento, opt => opt.MapFrom(src => src.FechaLanzamiento))
                .ForMember(dest => dest.IdCategoria, opt => opt.MapFrom(src => src.IdCategoria))
                .ForMember(dest => dest.Categoria, opt => opt.MapFrom(src => src.Categoria));
        }
    }
}
