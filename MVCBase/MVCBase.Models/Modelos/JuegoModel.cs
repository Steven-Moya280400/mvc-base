using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBase.Models.Modelos
{
    public class JuegoModel
    {
        public int? IdJuego { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaLanzamiento { get; set; }
        public int? IdCategoria { get; set; }
        public CategoriaModel? Categoria { get; set; }
    }
}
