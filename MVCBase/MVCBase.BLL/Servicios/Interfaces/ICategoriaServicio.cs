using MVCBase.Models.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBase.BLL.Servicios.Interfaces
{
    public interface ICategoriaServicio
    {
        public Task<List<CategoriaModel>> ObtenerCategoria();
    }
}
