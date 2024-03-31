using MVCBase.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBase.DAL.Repositorios.Interfaces
{
    public interface ICategoriaRepositorio
    {
        public Task<List<CategoriaDTO>> ObtenerCategoria();
    }
}
