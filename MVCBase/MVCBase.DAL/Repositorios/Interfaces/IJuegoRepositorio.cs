using MVCBase.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBase.DAL.Repositorios.Interfaces
{
    public interface IJuegoRepositorio
    {
        public Task<List<JuegoDTO>> ObtenerJuego();
        public Task<JuegoDTO> ObtenerJuegoPorId(int? idJuego);
    }
}
