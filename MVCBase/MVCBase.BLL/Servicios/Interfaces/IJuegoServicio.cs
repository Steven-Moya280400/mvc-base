using MVCBase.Models.DTOs;
using MVCBase.Models.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBase.BLL.Servicios.Interfaces
{
    public interface IJuegoServicio
    {
        public Task<List<JuegoModel>> ObtenerJuego();
        public Task<JuegoModel> ObtenerJuegoPorId(int? idJuego);
    }
}
