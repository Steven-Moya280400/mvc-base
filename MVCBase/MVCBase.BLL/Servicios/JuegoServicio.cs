using AutoMapper;
using MVCBase.BLL.Servicios.Interfaces;
using MVCBase.DAL.Repositorios.Interfaces;
using MVCBase.Models.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBase.BLL.Servicios
{
    public class JuegoServicio : IJuegoServicio
    {
        private readonly IJuegoRepositorio _juegoRepositorio;
        private readonly IMapper _mapper;

        public JuegoServicio(IJuegoRepositorio juegoRepositorio, IMapper mapper)
        {
            _juegoRepositorio = juegoRepositorio;
            _mapper = mapper;
        }

        public async Task<List<JuegoModel>> ObtenerJuego()
        {
            return _mapper.Map<List<JuegoModel>>(await _juegoRepositorio.ObtenerJuego());
        }

        public async Task<JuegoModel> ObtenerJuegoPorId(int? idJuego)
        {
            return _mapper.Map<JuegoModel>(await _juegoRepositorio.ObtenerJuegoPorId(idJuego));
        }
    }
}
