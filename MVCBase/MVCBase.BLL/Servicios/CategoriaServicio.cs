using AutoMapper;
using MVCBase.BLL.Servicios.Interfaces;
using MVCBase.DAL.Repositorios.Interfaces;
using MVCBase.Models.DTOs;
using MVCBase.Models.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBase.BLL.Servicios
{
    public class CategoriaServicio : ICategoriaServicio
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        private readonly IMapper _mapper;

        public CategoriaServicio(ICategoriaRepositorio categoriaRepositorio, IMapper mapper)
        {
            _categoriaRepositorio = categoriaRepositorio;
            _mapper = mapper;
        }

        public async Task<List<CategoriaModel>> ObtenerCategoria()
        {
            return _mapper.Map<List<CategoriaModel>>(await _categoriaRepositorio.ObtenerCategoria());
        }
    }
}
