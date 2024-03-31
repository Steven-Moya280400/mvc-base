using Dapper;
using Microsoft.Extensions.Configuration;
using MVCBase.DAL.Core;
using MVCBase.DAL.Repositorios.Interfaces;
using MVCBase.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBase.DAL.Repositorios
{
    internal class JuegoRepositorio : BaseRepositorio, IJuegoRepositorio
    {
        public JuegoRepositorio(IConfiguration configuration) : base(configuration){}

        public async Task<List<JuegoDTO>> ObtenerJuego()
        {
            using (IDbConnection bd = CrearConexionConBD())
            {
                const string nombreSP = "sp_ObtenerVideojuego";
                return (await bd.QueryAsync<JuegoDTO>(nombreSP, commandType: CommandType.StoredProcedure)).ToList();
            }
        }

        public async Task<JuegoDTO?> ObtenerJuegoPorId(int? idJuego)
        {
            using (IDbConnection bd = CrearConexionConBD())
            {
                const string nombreSP = "sp_ObtenerMensajeProgramadoPorId";
                var parametros = new { pIdJuego = idJuego };
                return await bd.QueryFirstOrDefaultAsync<JuegoDTO?>(nombreSP, parametros, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
