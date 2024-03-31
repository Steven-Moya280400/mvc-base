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
    public class CategoriaRepositorio : BaseRepositorio, ICategoriaRepositorio
    {
        public CategoriaRepositorio(IConfiguration configuration) : base(configuration){}

        public async Task<List<CategoriaDTO>> ObtenerCategoria()
        {
            using (IDbConnection bd = CrearConexionConBD())
            {
                const string nombreSP = "sp_ObtenerCategoria";
                return (await bd.QueryAsync<CategoriaDTO>(nombreSP, commandType: CommandType.StoredProcedure)).ToList();
            }
        }
    }
}
