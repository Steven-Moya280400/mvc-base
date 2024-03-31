using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBase.Models.DTOs
{
    public class JuegoDTO
    {
        public int? IdJuego { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaLanzamiento { get; set; }
        public int? IdCategoria { get; set; }
        public CategoriaDTO? Categoria { get; set; }
    }
}
